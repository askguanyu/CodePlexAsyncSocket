﻿//-----------------------------------------------------------------------
// <copyright file="AsyncSocketServer.cs" company="GY Corporation">
//     Copyright (c) GY Corporation. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------
namespace AsyncSocket
{
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.Diagnostics;
    using System.Net;
    using System.Net.Sockets;
    using System.Threading;

    /// <summary>
    /// Implements the connection logic for the socket server.
    /// </summary>
    public class AsyncSocketServer : IDisposable
    {
        /// <summary>
        ///
        /// </summary>
        private Object _bufferLock = new Object();

        /// <summary>
        ///
        /// </summary>
        private Object _readPoolLock = new Object();

        /// <summary>
        ///
        /// </summary>
        private Object _writePoolLock = new Object();

        /// <summary>
        ///
        /// </summary>
        private Dictionary<Guid, AsyncSocketUserToken> _tokens;

        /// <summary>
        /// the maximum number of connections the class is designed to handle simultaneously
        /// </summary>
        private int _numConnections;

        /// <summary>
        /// buffer size to use for each socket I/O operation
        /// </summary>
        private int _bufferSize;

        /// <summary>
        /// represents a large reusable set of buffers for all socket operations
        /// </summary>
        private SocketAsyncEventArgsBufferManager _bufferManager;

        /// <summary>
        /// the socket used to listen for incoming connection requests
        /// </summary>
        private Socket _listenSocket;

        /// <summary>
        /// pool of reusable SocketAsyncEventArgs objects for read and accept socket operations
        /// </summary>
        private SocketAsyncEventArgsPool _readPool;

        /// <summary>
        /// pool of reusable SocketAsyncEventArgs objects for write and accept socket operations
        /// </summary>
        private SocketAsyncEventArgsPool _writePool;

        /// <summary>
        /// counter of the total bytes received by the server
        /// </summary>
        private long _totalBytesRead;

        /// <summary>
        /// counter of the total bytes sent by the server
        /// </summary>
        private long _totalBytesWrite;

        /// <summary>
        /// the total number of clients connected to the server
        /// </summary>
        private long _numConnectedSockets;

        /// <summary>
        /// the max number of accepted clients
        /// </summary>
        private Semaphore _maxNumberAcceptedClients;

        /// <summary>
        /// Constructor of AsyncSocketServer
        /// </summary>
        /// <param name="localEndPoint">local port to listen</param>
        /// <param name="numConnections">the maximum number of connections the class is designed to handle simultaneously</param>
        /// <param name="bufferSize">buffer size to use for each socket I/O operation</param>
        public AsyncSocketServer(IPEndPoint localEndPoint, int numConnections = AsyncSocketConstants.NumConnections, int bufferSize = AsyncSocketConstants.BufferSize)
        {
            this._totalBytesRead = 0;
            this._totalBytesWrite = 0;
            this._numConnectedSockets = 0;
            this._numConnections = numConnections;
            this._bufferSize = bufferSize;
            this.LocalEndPoint = localEndPoint;
        }

        /// <summary>
        /// Client Connected Event
        /// </summary>
        public event EventHandler<AsyncSocketUserToken> Connected;

        /// <summary>
        /// Error Occurred Event
        /// </summary>
        public event EventHandler<AsyncSocketErrorEventArgs> ErrorOccurred;

        /// <summary>
        /// Client Data Received Event
        /// </summary>
        public event EventHandler<AsyncSocketUserToken> DataReceived;

        /// <summary>
        /// Client Data Sent Event
        /// </summary>
        public event EventHandler<AsyncSocketUserToken> DataSent;

        /// <summary>
        /// Client Disconnected Event
        /// </summary>
        public event EventHandler<AsyncSocketUserToken> Disconnected;

        /// <summary>
        /// Gets a value indicating whether socket server is listening
        /// </summary>
        public bool IsListening
        {
            get;
            private set;
        }

        /// <summary>
        /// Gets Local EndPoint
        /// </summary>
        public IPEndPoint LocalEndPoint
        {
            get;
            private set;
        }

        /// <summary>
        /// Gets numbers of connected sockets
        /// </summary>
        public long NumConnectedSockets
        {
            get { return _numConnectedSockets; }
        }

        /// <summary>
        /// Gets total bytes read
        /// </summary>
        public long TotalBytesRead
        {
            get { return _totalBytesRead; }
        }

        /// <summary>
        /// Gets total bytes write
        /// </summary>
        public long TotalBytesWrite
        {
            get { return _totalBytesWrite; }
        }

        /// <summary>
        /// Whether connected client is online or not
        /// </summary>
        /// <param name="connectionId">Connection Id</param>
        /// <returns>true if online, else false</returns>
        public bool IsOnline(Guid connectionId)
        {
            lock (((ICollection)this._tokens).SyncRoot)
            {
                if (!this._tokens.ContainsKey(connectionId))
                {
                    return false;
                }
                else
                {
                    return true;
                }
            }
        }

        /// <summary>
        /// Start socket server
        /// </summary>
        public void Start()
        {
            this.Start(this.LocalEndPoint);
        }

        /// <summary>
        /// Start socket server to listen specific local port
        /// </summary>
        /// <param name="localEndPoint">local port to listen</param>
        public void Start(IPEndPoint localEndPoint)
        {
            if (!this.IsListening)
            {
                this.InitializePool();

                try
                {
                    if (null != this._listenSocket)
                    {
                        this._listenSocket.Close();
                        this._listenSocket.Dispose();
                        this._listenSocket = null;
                    }

                    this._listenSocket = new Socket(localEndPoint.AddressFamily, SocketType.Stream, ProtocolType.Tcp);
                    this._listenSocket.Bind(localEndPoint);
                    this._listenSocket.Listen(AsyncSocketConstants.Backlog);
                }
                catch (ObjectDisposedException)
                {
                    this.IsListening = false;
                }
                catch (SocketException)
                {
                    this.IsListening = false;
                    throw new AsyncSocketException(AsyncSocketConstants.SocketStartException, AsyncSocketErrorCodeEnum.ServerStartFailure);
                }
                catch (Exception ex)
                {
                    this.IsListening = false;
                    Debug.WriteLine(string.Format(AsyncSocketConstants.DebugStringFormat, ex.Message));
                    throw;
                }

                this.IsListening = true;
                StartAccept(null);

                Debug.WriteLine(string.Format(AsyncSocketConstants.SocketStartSuccessfully));
            }
        }

        /// <summary>
        /// Send the data back to the client
        /// </summary>
        /// <param name="connectionId">Client connection Id</param>
        /// <param name="buffer">Data to send</param>
        public void Send(Guid connectionId, byte[] buffer)
        {
            AsyncSocketUserToken token;

            lock (((ICollection)this._tokens).SyncRoot)
            {
                if (!this._tokens.TryGetValue(connectionId, out token))
                {
                    throw new AsyncSocketException(string.Format(AsyncSocketConstants.ClientClosedStringFormat, connectionId), AsyncSocketErrorCodeEnum.ClientSocketNoExist);
                }
            }

            SocketAsyncEventArgs writeEventArgs;

            lock (_writePool)
            {
                writeEventArgs = _writePool.Pop();
            }

            writeEventArgs.UserToken = token;

            if (buffer.Length <= _bufferSize)
            {
                Array.Copy(buffer, 0, writeEventArgs.Buffer, writeEventArgs.Offset, buffer.Length);
                writeEventArgs.SetBuffer(writeEventArgs.Buffer, writeEventArgs.Offset, buffer.Length);
            }
            else
            {
                lock (_bufferLock)
                {
                    _bufferManager.FreeBuffer(writeEventArgs);
                }

                writeEventArgs.SetBuffer(buffer, 0, buffer.Length);
            }

            try
            {
                bool willRaiseEvent = token.Socket.SendAsync(writeEventArgs);
                if (!willRaiseEvent)
                {
                    ProcessSend(writeEventArgs);
                }
            }
            catch (ObjectDisposedException)
            {
                RaiseDisconnectedEvent(token);
            }
            catch (SocketException socketException)
            {
                if (socketException.ErrorCode == (int)SocketError.ConnectionReset)
                {
                    RaiseDisconnectedEvent(token);
                }
                else
                {
                    RaiseErrorEvent(token, new AsyncSocketException(AsyncSocketConstants.SocketSendException, socketException));
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine(string.Format(AsyncSocketConstants.DebugStringFormat, ex.Message));
                throw;
            }
        }

        /// <summary>
        /// Send the data back to the client
        /// </summary>
        /// <param name="connectionId">Client connection Id</param>
        /// <param name="buffer">Data to send</param>
        /// <param name="operation">user defined operation</param>
        public void Send(Guid connectionId, byte[] buffer, object operation)
        {
            AsyncSocketUserToken token;

            lock (((ICollection)this._tokens).SyncRoot)
            {
                if (!this._tokens.TryGetValue(connectionId, out token))
                {
                    throw new AsyncSocketException(string.Format(AsyncSocketConstants.ClientClosedStringFormat, connectionId), AsyncSocketErrorCodeEnum.ClientSocketNoExist);
                }
            }

            SocketAsyncEventArgs writeEventArgs;

            lock (_writePool)
            {
                writeEventArgs = _writePool.Pop();
            }

            writeEventArgs.UserToken = token;
            token.Operation = operation;

            if (buffer.Length <= _bufferSize)
            {
                Array.Copy(buffer, 0, writeEventArgs.Buffer, writeEventArgs.Offset, buffer.Length);
            }
            else
            {
                lock (_bufferLock)
                {
                    _bufferManager.FreeBuffer(writeEventArgs);
                }

                writeEventArgs.SetBuffer(buffer, 0, buffer.Length);
            }

            try
            {
                bool willRaiseEvent = token.Socket.SendAsync(writeEventArgs);
                if (!willRaiseEvent)
                {
                    ProcessSend(writeEventArgs);
                }
            }
            catch (ObjectDisposedException)
            {
                RaiseDisconnectedEvent(token);
            }
            catch (SocketException socketException)
            {
                if (socketException.ErrorCode == (int)SocketError.ConnectionReset)
                {
                    RaiseDisconnectedEvent(token);
                }
                else
                {
                    RaiseErrorEvent(token, new AsyncSocketException(AsyncSocketConstants.SocketSendException, socketException));
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine(string.Format(AsyncSocketConstants.DebugStringFormat, ex.Message));
                throw;
            }
        }

        /// <summary>
        /// Disconnect client
        /// </summary>
        /// <param name="connectionId">Client connection Id</param>
        public void Disconnect(Guid connectionId)
        {
            AsyncSocketUserToken token;

            lock (((ICollection)this._tokens).SyncRoot)
            {
                if (!this._tokens.TryGetValue(connectionId, out token))
                {
                    throw new AsyncSocketException(string.Format(AsyncSocketConstants.ClientClosedStringFormat, connectionId), AsyncSocketErrorCodeEnum.ClientSocketNoExist);
                }
            }

            RaiseDisconnectedEvent(token);
        }

        /// <summary>
        /// Stop socket server
        /// </summary>
        public void Stop()
        {
            if (this.IsListening)
            {
                this.IsListening = false;

                try
                {
                    this._listenSocket.Close();
                }
                catch (Exception ex)
                {
                    Debug.WriteLine(string.Format(AsyncSocketConstants.DebugStringFormat, ex.Message));
                }

                lock (((ICollection)this._tokens).SyncRoot)
                {
                    foreach (AsyncSocketUserToken token in this._tokens.Values)
                    {
                        try
                        {
                            this.CloseClientSocket(token);

                            if (null != token)
                            {
                                this.OnDisconnected(token);
                            }
                        }
                        catch (Exception ex)
                        {
                            Debug.WriteLine(string.Format(AsyncSocketConstants.ClientClosedStringFormat, ex.Message));
                            throw;
                        }
                    }

                    this._tokens.Clear();
                }
            }
        }

        /// <summary>
        ///
        /// </summary>
        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        /// <summary>
        ///
        /// </summary>
        /// <param name="e"></param>
        protected virtual void OnConnected(AsyncSocketUserToken e)
        {
            // Copy a reference to the delegate field now into a temporary field for thread safety
            EventHandler<AsyncSocketUserToken> temp = Interlocked.CompareExchange(ref Connected, null, null);

            if ((temp != null) && (e.EndPoint != null))
            {
                temp(this, e);
            }
        }

        /// <summary>
        ///
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected virtual void OnErrorOccurred(object sender, AsyncSocketErrorEventArgs e)
        {
            // Copy a reference to the delegate field now into a temporary field for thread safety
            EventHandler<AsyncSocketErrorEventArgs> temp = Interlocked.CompareExchange(ref ErrorOccurred, null, null);

            if (temp != null)
            {
                temp(sender, e);
            }
        }

        /// <summary>
        ///
        /// </summary>
        /// <param name="e"></param>
        protected virtual void OnDataReceived(AsyncSocketUserToken e)
        {
            // Copy a reference to the delegate field now into a temporary field for thread safety
            EventHandler<AsyncSocketUserToken> temp = Interlocked.CompareExchange(ref DataReceived, null, null);

            if ((temp != null) && (e.EndPoint != null))
            {
                temp(this, e);
            }
        }

        /// <summary>
        ///
        /// </summary>
        /// <param name="e"></param>
        protected virtual void OnDataSent(AsyncSocketUserToken e)
        {
            // Copy a reference to the delegate field now into a temporary field for thread safety
            EventHandler<AsyncSocketUserToken> temp = Interlocked.CompareExchange(ref DataSent, null, null);

            if (temp != null)
            {
                temp(this, e);
            }
        }

        /// <summary>
        ///
        /// </summary>
        /// <param name="e"></param>
        protected virtual void OnDisconnected(AsyncSocketUserToken e)
        {
            // Copy a reference to the delegate field now into a temporary field for thread safety
            EventHandler<AsyncSocketUserToken> temp = Interlocked.CompareExchange(ref Disconnected, null, null);

            if ((temp != null) && (e.EndPoint != null))
            {
                temp(this, e);
            }
        }

        /// <summary>
        ///
        /// </summary>
        /// <param name="disposing"></param>
        protected virtual void Dispose(bool disposing)
        {
            if (disposing)
            {
                // dispose managed resources
                if (this._listenSocket != null)
                {
                    this._listenSocket.Close();
                    this._listenSocket.Dispose();
                }

                this._maxNumberAcceptedClients.Dispose();
            }

            // free native resources
        }

        /// <summary>
        /// Initialize Read/Write Pool
        /// </summary>
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Reliability", "CA2000:Dispose objects before losing scope")]
        private void InitializePool()
        {
            this._bufferManager = new SocketAsyncEventArgsBufferManager(_bufferSize * _numConnections * AsyncSocketConstants.OpsToPreAlloc, _bufferSize);
            this._readPool = new SocketAsyncEventArgsPool(_numConnections);
            this._writePool = new SocketAsyncEventArgsPool(_numConnections);
            this._tokens = new Dictionary<Guid, AsyncSocketUserToken>();
            this._maxNumberAcceptedClients = new Semaphore(_numConnections, _numConnections);

            this._bufferManager.InitBuffer();

            SocketAsyncEventArgs readWriteEventArg;
            AsyncSocketUserToken token;

            /// Initialize read Pool
            for (int i = 0; i < _numConnections; i++)
            {
                token = new AsyncSocketUserToken();
                token.ReadEventArgs.Completed += new EventHandler<SocketAsyncEventArgs>(IO_Completed);
                this._bufferManager.SetBuffer(token.ReadEventArgs);
                token.SetBuffer(token.ReadEventArgs.Buffer, token.ReadEventArgs.Offset);
                this._readPool.Push(token.ReadEventArgs);
            }

            /// Initialize write Pool
            for (int i = 0; i < _numConnections; i++)
            {
                readWriteEventArg = new SocketAsyncEventArgs();
                readWriteEventArg.Completed += new EventHandler<SocketAsyncEventArgs>(IO_Completed);
                readWriteEventArg.UserToken = null;
                this._bufferManager.SetBuffer(readWriteEventArg);
                this._writePool.Push(readWriteEventArg);
            }
        }

        /// <summary>
        ///
        /// </summary>
        /// <param name="acceptEventArg"></param>
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Reliability", "CA2000:Dispose objects before losing scope")]
        private void StartAccept(SocketAsyncEventArgs acceptEventArg)
        {
            if (acceptEventArg == null)
            {
                acceptEventArg = new SocketAsyncEventArgs();
                acceptEventArg.Completed += new EventHandler<SocketAsyncEventArgs>(AcceptEventArg_Completed);
            }
            else
            {
                acceptEventArg.AcceptSocket = null;
            }

            try
            {
                _maxNumberAcceptedClients.WaitOne();

                bool willRaiseEvent = _listenSocket.AcceptAsync(acceptEventArg);
                if (!willRaiseEvent)
                {
                    ProcessAccept(acceptEventArg);
                }
            }
            catch (ObjectDisposedException ex)
            {
                Debug.WriteLine(string.Format(AsyncSocketConstants.DebugStringFormat, ex.Message));
            }
            catch (SocketException ex)
            {
                Debug.WriteLine(string.Format(AsyncSocketConstants.DebugStringFormat, ex.Message));
                RaiseErrorEvent(null, new AsyncSocketException(AsyncSocketConstants.SocketAcceptedException, ex));
            }
            catch (Exception ex)
            {
                Debug.WriteLine(string.Format(AsyncSocketConstants.DebugStringFormat, ex.Message));
                throw;
            }
        }

        /// <summary>
        ///
        /// </summary>
        private void AcceptEventArg_Completed(object sender, SocketAsyncEventArgs e)
        {
            ProcessAccept(e);
        }

        /// <summary>
        ///
        /// </summary>
        /// <param name="e"></param>
        private void ProcessAccept(SocketAsyncEventArgs e)
        {
            AsyncSocketUserToken token;
            Interlocked.Increment(ref _numConnectedSockets);
            Debug.WriteLine(string.Format(AsyncSocketConstants.ClientConnectionStringFormat, _numConnectedSockets.ToString()));
            SocketAsyncEventArgs readEventArg;

            lock (_readPool)
            {
                readEventArg = _readPool.Pop();
            }

            token = (AsyncSocketUserToken)readEventArg.UserToken;

            token.Socket = e.AcceptSocket;

            token.ConnectionId = Guid.NewGuid();

            lock (((ICollection)this._tokens).SyncRoot)
            {
                this._tokens.Add(token.ConnectionId, token);
            }

            this.OnConnected(token);

            try
            {
                bool willRaiseEvent = token.Socket.ReceiveAsync(readEventArg);
                if (!willRaiseEvent)
                {
                    ProcessReceive(readEventArg);
                }
            }
            catch (ObjectDisposedException)
            {
                RaiseDisconnectedEvent(token);
            }
            catch (SocketException socketException)
            {
                if (socketException.ErrorCode == (int)SocketError.ConnectionReset)
                {
                    RaiseDisconnectedEvent(token);
                }
                else
                {
                    RaiseErrorEvent(token, new AsyncSocketException(AsyncSocketConstants.SocketReceiveException, socketException));
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine(string.Format(AsyncSocketConstants.DebugStringFormat, ex.Message));
                RaiseErrorEvent(token, new AsyncSocketException(ex.Message, AsyncSocketErrorCodeEnum.ThrowSocketException));
            }
            finally
            {
                StartAccept(e);
            }
        }

        /// <summary>
        ///
        /// </summary>
        /// <param name="e"></param>
        private void IO_Completed(object sender, SocketAsyncEventArgs e)
        {
            switch (e.LastOperation)
            {
                case SocketAsyncOperation.Receive:
                    ProcessReceive(e);
                    break;
                case SocketAsyncOperation.Send:
                    ProcessSend(e);
                    break;
                default:
                    throw new ArgumentException(AsyncSocketConstants.SocketLastOperationException);
            }
        }

        /// <summary>
        ///
        /// </summary>
        /// <param name="e"></param>
        private void ProcessReceive(SocketAsyncEventArgs e)
        {
            AsyncSocketUserToken token = (AsyncSocketUserToken)e.UserToken;

            if (e.BytesTransferred > 0 && e.SocketError == SocketError.Success)
            {
                Interlocked.Add(ref _totalBytesRead, e.BytesTransferred);
                Debug.WriteLine(string.Format(AsyncSocketConstants.ServerReceiveTotalBytesStringFormat, this._totalBytesRead.ToString()));

                token.SetBytesReceived(e.BytesTransferred);

                this.OnDataReceived(token);

                try
                {
                    bool willRaiseEvent = token.Socket.ReceiveAsync(e);
                    if (!willRaiseEvent)
                    {
                        ProcessReceive(e);
                    }
                }
                catch (ObjectDisposedException)
                {
                    RaiseDisconnectedEvent(token);
                }
                catch (SocketException socketException)
                {
                    if (socketException.ErrorCode == (int)SocketError.ConnectionReset)
                    {
                        RaiseDisconnectedEvent(token);
                    }
                    else
                    {
                        RaiseErrorEvent(token, new AsyncSocketException(AsyncSocketConstants.SocketReceiveException, socketException));
                    }
                }
                catch (Exception ex)
                {
                    Debug.WriteLine(string.Format(AsyncSocketConstants.DebugStringFormat, ex.Message));
                    throw;
                }
            }
            else
            {
                RaiseDisconnectedEvent(token);
            }
        }

        /// <summary>
        ///
        /// </summary>
        /// <param name="e"></param>
        private void ProcessSend(SocketAsyncEventArgs e)
        {
            AsyncSocketUserToken token = (AsyncSocketUserToken)e.UserToken;

            Interlocked.Add(ref _totalBytesWrite, e.BytesTransferred);

            if (e.Count > _bufferSize)
            {
                lock (_bufferLock)
                {
                    _bufferManager.SetBuffer(e);
                }
            }

            lock (_writePool)
            {
                _writePool.Push(e);
            }

            e.UserToken = null;

            if (e.SocketError == SocketError.Success)
            {
                Debug.WriteLine(string.Format(AsyncSocketConstants.ServerSendTotalBytesStringFormat, e.BytesTransferred.ToString()));

                this.OnDataSent(token);
            }
            else
            {
                RaiseDisconnectedEvent(token);
            }
        }

        /// <summary>
        ///
        /// </summary>
        /// <param name="token"></param>
        private void RaiseDisconnectedEvent(AsyncSocketUserToken token)
        {
            if (null != token)
            {
                lock (((ICollection)this._tokens).SyncRoot)
                {
                    if (this._tokens.ContainsValue(token))
                    {
                        this._tokens.Remove(token.ConnectionId);
                        CloseClientSocket(token);

                        if (null != token)
                        {
                            this.OnDisconnected(token);
                        }
                    }
                }
            }
        }

        /// <summary>
        ///
        /// </summary>
        /// <param name="token"></param>
        private void CloseClientSocket(AsyncSocketUserToken token)
        {
            try
            {
                token.Socket.Shutdown(SocketShutdown.Both);
                token.Socket.Close();
            }
            catch (ObjectDisposedException)
            {
            }
            catch (SocketException)
            {
                token.Socket.Close();
            }
            catch (Exception ex)
            {
                token.Socket.Close();
                Debug.WriteLine(string.Format(AsyncSocketConstants.DebugStringFormat, ex.Message));
                throw;
            }
            finally
            {
                Interlocked.Decrement(ref _numConnectedSockets);
                this._maxNumberAcceptedClients.Release();

                Debug.WriteLine(string.Format(AsyncSocketConstants.ClientConnectionStringFormat, _numConnectedSockets.ToString()));

                lock (_readPool)
                {
                    _readPool.Push(token.ReadEventArgs);
                }
            }
        }

        /// <summary>
        ///
        /// </summary>
        /// <param name="token"></param>
        /// <param name="exception"></param>
        private void RaiseErrorEvent(AsyncSocketUserToken token, AsyncSocketException exception)
        {
            if (null != token)
            {
                this.OnErrorOccurred(token, new AsyncSocketErrorEventArgs(exception));
            }
            else
            {
                this.OnErrorOccurred(null, new AsyncSocketErrorEventArgs(exception));
            }
        }
    }
}