//-----------------------------------------------------------------------
// <copyright file="AsyncSocketClient.cs" company="GY Corporation">
//     Copyright (c) GY Corporation. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------
namespace AsyncSocket
{
    using System;
    using System.Diagnostics;
    using System.Net;
    using System.Net.Sockets;
    using System.Text;
    using System.Threading;

    /// <summary>
    /// AsyncSocket Client
    /// </summary>
    public class AsyncSocketClient : IDisposable
    {
        /// <summary>
        ///
        /// </summary>
        private int _bufferSize;

        /// <summary>
        ///
        /// </summary>
        private Socket _socketClient = null;

        /// <summary>
        ///
        /// </summary>
        private byte[] _dataBuffer;

        /// <summary>
        /// Constructor of AsyncSocketClient
        /// </summary>
        /// <param name="bufferSize">Buffer size of data to be sent</param>
        public AsyncSocketClient(int bufferSize = AsyncSocketClientConstants.BufferSize)
        {
            this._bufferSize = bufferSize;
            this._dataBuffer = new byte[this._bufferSize];
        }

        /// <summary>
        ///
        /// </summary>
        public event EventHandler<AsyncSocketClientConnectedEventArgs> Connected;

        /// <summary>
        ///
        /// </summary>
        public event EventHandler<AsyncSocketClientDisconnectedEventArgs> Disconnected;

        /// <summary>
        ///
        /// </summary>
        public event EventHandler<AsyncSocketClientDataReceivedEventArgs> DataReceived;

        /// <summary>
        ///
        /// </summary>
        public event EventHandler<AsyncSocketClientErrorOccurredEventArgs> ErrorOccurred;

        /// <summary>
        /// Connect to remote endpoint
        /// </summary>
        /// <param name="remoteEndPoint">Remote IPEndPoint</param>
        /// <param name="useIOCP">Specifies whether the socket should only use Overlapped I/O mode.</param>
        public void Connect(IPEndPoint remoteEndPoint, bool useIOCP = true)
        {
            this._socketClient = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            try
            {
                this._socketClient.UseOnlyOverlappedIO = useIOCP;
                this._socketClient.BeginConnect(remoteEndPoint, new AsyncCallback(this.ProcessConnect), this._socketClient);
                Debug.WriteLine(AsyncSocketClientConstants.ClientConnectSuccessfully);
            }
            catch (ObjectDisposedException e)
            {
                Debug.WriteLine(string.Format(AsyncSocketClientConstants.ClientConnectExceptionStringFormat, e.Message));
                this.OnDisconnected(new AsyncSocketClientDisconnectedEventArgs(this._socketClient));
            }
            catch (SocketException e)
            {
                Debug.WriteLine(string.Format(AsyncSocketClientConstants.ClientConnectExceptionStringFormat, e.Message));
                this.HandleSocketException(e);
            }
        }

        /// <summary>
        /// Connect to remote endpoint
        /// </summary>
        /// <param name="ip">Remote IP</param>
        /// <param name="port">Remote port</param>
        /// <param name="useIOCP">Specifies whether the socket should only use Overlapped I/O mode.</param>
        public void Connect(string ip, int port, bool useIOCP = true)
        {
            IPEndPoint remoteEndPoint = new IPEndPoint(IPAddress.Parse(ip), port);
            this.Connect(remoteEndPoint, useIOCP);
        }

        /// <summary>
        /// Send binary data, call Connect method before using this method
        /// </summary>
        /// <param name="data">Data to be sent</param>
        public void Send(byte[] data)
        {
            try
            {
                this._socketClient.BeginSend(data, 0, data.Length, SocketFlags.None, new AsyncCallback(this.ProcessSendFinished), this._socketClient);
                Debug.WriteLine(string.Format(AsyncSocketClientConstants.ClientSendBytesStringFormat, data.Length));
            }
            catch (ObjectDisposedException e)
            {
                Debug.WriteLine(string.Format(AsyncSocketClientConstants.ClientSendExceptionStringFormat, e.Message));
                this.OnDisconnected(new AsyncSocketClientDisconnectedEventArgs(this._socketClient));
            }
            catch (SocketException e)
            {
                Debug.WriteLine(string.Format(AsyncSocketClientConstants.ClientSendExceptionStringFormat, e.Message));
                this.HandleSocketException(e);
            }
        }

        /// <summary>
        /// Send strings, call Connect method before using this method
        /// </summary>
        /// <param name="message">Message to be sent</param>
        /// <param name="encoding">Character encoding</param>
        public void Send(string message, Encoding encoding)
        {
            byte[] data = encoding.GetBytes(message);
            this.Send(data);
        }

        /// <summary>
        /// Send binary data once
        /// </summary>
        /// <param name="remoteEndPoint">Remote endpoint</param>
        /// <param name="data">Data to be sent</param>
        public void SendOnce(IPEndPoint remoteEndPoint, byte[] data)
        {
            this.Connect(remoteEndPoint);
            this.Send(data);
            this.Disconnect();
        }

        /// <summary>
        /// Send strings once
        /// </summary>
        /// <param name="remoteEndPoint">Remote endpoint</param>
        /// <param name="message">Message to be sent</param>
        /// <param name="encoding">Character encoding</param>
        public void SendOnce(IPEndPoint remoteEndPoint, string message, Encoding encoding)
        {
            this.Connect(remoteEndPoint);
            this.Send(message, encoding);
            this.Disconnect();
        }

        /// <summary>
        /// Send binary data once
        /// </summary>
        /// <param name="ip">Remote IP</param>
        /// <param name="port">Remote port</param>
        /// <param name="data">Data to be sent</param>
        public void SendOnce(string ip, int port, byte[] data)
        {
            this.Connect(ip, port);
            this.Send(data);
            this.Disconnect();
        }

        /// <summary>
        /// Send strings once
        /// </summary>
        /// <param name="ip">Remote IP</param>
        /// <param name="port">Remote port</param>
        /// <param name="message">Message to be sent</param>
        /// <param name="encoding">Character encoding</param>
        public void SendOnce(string ip, int port, string message, Encoding encoding)
        {
            this.Connect(ip, port);
            this.Send(message, encoding);
            this.Disconnect();
        }

        /// <summary>
        /// Disconnect client
        /// </summary>
        public void Disconnect()
        {
            try
            {
                this._socketClient.Shutdown(SocketShutdown.Both);
                this._socketClient.Close();
            }
            catch (Exception e)
            {
                Debug.WriteLine(string.Format(AsyncSocketClientConstants.ClientDisconnectExceptionStringFormat, e.Message));
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
        protected virtual void OnConnected(AsyncSocketClientConnectedEventArgs e)
        {
            // Copy a reference to the delegate field now into a temporary field for thread safety
            EventHandler<AsyncSocketClientConnectedEventArgs> temp = Interlocked.CompareExchange(ref Connected, null, null);

            if (temp != null)
            {
                temp(this, e);
            }
        }

        /// <summary>
        ///
        /// </summary>
        /// <param name="e"></param>
        protected virtual void OnDisconnected(AsyncSocketClientDisconnectedEventArgs e)
        {
            // Copy a reference to the delegate field now into a temporary field for thread safety
            EventHandler<AsyncSocketClientDisconnectedEventArgs> temp = Interlocked.CompareExchange(ref Disconnected, null, null);

            if ((temp != null) && (e.SocketToken != null))
            {
                temp(this, e);
            }
        }

        /// <summary>
        ///
        /// </summary>
        /// <param name="e"></param>
        protected virtual void OnDataReceived(AsyncSocketClientDataReceivedEventArgs e)
        {
            // Copy a reference to the delegate field now into a temporary field for thread safety
            EventHandler<AsyncSocketClientDataReceivedEventArgs> temp = Interlocked.CompareExchange(ref DataReceived, null, null);

            if (temp != null)
            {
                temp(this, e);
            }
        }

        /// <summary>
        ///
        /// </summary>
        /// <param name="e"></param>
        protected virtual void OnErrorOccurred(AsyncSocketClientErrorOccurredEventArgs e)
        {
            // Copy a reference to the delegate field now into a temporary field for thread safety
            EventHandler<AsyncSocketClientErrorOccurredEventArgs> temp = Interlocked.CompareExchange(ref ErrorOccurred, null, null);

            if (temp != null)
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
                if (this._socketClient != null)
                {
                    this._socketClient.Shutdown(SocketShutdown.Both);
                    this._socketClient.Close();
                    this._socketClient.Dispose();
                }
            }
        }

        /// <summary>
        ///
        /// </summary>
        /// <param name="asyncResult"></param>
        private void ProcessConnect(IAsyncResult asyncResult)
        {
            Socket asyncState = (Socket)asyncResult.AsyncState;
            try
            {
                asyncState.EndConnect(asyncResult);
                this.OnConnected(new AsyncSocketClientConnectedEventArgs(this._socketClient));
                this.ProcessWaitForData(asyncState);
            }
            catch (ObjectDisposedException e)
            {
                this.OnDisconnected(new AsyncSocketClientDisconnectedEventArgs(this._socketClient));
            }
            catch (SocketException e)
            {
                this.HandleSocketException(e);
            }
        }

        /// <summary>
        ///
        /// </summary>
        /// <param name="socket"></param>
        private void ProcessWaitForData(Socket socket)
        {
            try
            {
                socket.BeginReceive(this._dataBuffer, 0, this._bufferSize, SocketFlags.None, new AsyncCallback(this.ProcessIncomingData), socket);
            }
            catch (ObjectDisposedException e)
            {
                this.OnDisconnected(new AsyncSocketClientDisconnectedEventArgs(this._socketClient));
            }
            catch (SocketException e)
            {
                this.HandleSocketException(e);
            }
        }

        /// <summary>
        ///
        /// </summary>
        /// <param name="asyncResult"></param>
        private void ProcessIncomingData(IAsyncResult asyncResult)
        {
            Socket asyncState = (Socket)asyncResult.AsyncState;
            try
            {
                int length = asyncState.EndReceive(asyncResult);
                if (0 == length)
                {
                    this.OnDisconnected(new AsyncSocketClientDisconnectedEventArgs(this._socketClient));
                }
                else
                {
                    byte[] destinationArray = new byte[length];
                    Array.Copy(this._dataBuffer, 0, destinationArray, 0, length);
                    if (null != this.DataReceived)
                    {
                        this.DataReceived(this, new AsyncSocketClientDataReceivedEventArgs(this._socketClient, destinationArray));
                    }

                    this.ProcessWaitForData(asyncState);
                }
            }
            catch (ObjectDisposedException e)
            {
                this.OnDisconnected(new AsyncSocketClientDisconnectedEventArgs(this._socketClient));
            }
            catch (SocketException e)
            {
                this.HandleSocketException(e);
            }
        }

        /// <summary>
        ///
        /// </summary>
        /// <param name="asyncResult"></param>
        private void ProcessSendFinished(IAsyncResult asyncResult)
        {
            try
            {
                ((Socket)asyncResult.AsyncState).EndSend(asyncResult);
            }
            catch (ObjectDisposedException)
            {
                this.OnDisconnected(new AsyncSocketClientDisconnectedEventArgs(this._socketClient));
            }
            catch (SocketException e)
            {
                this.HandleSocketException(e);
            }
            catch (Exception e)
            {
                Debug.WriteLine(string.Format(AsyncSocketClientConstants.DebugStringFormat, e.Message));
            }
        }

        /// <summary>
        ///
        /// </summary>
        /// <param name="e"></param>
        private void HandleSocketException(SocketException e)
        {
            if (e.ErrorCode == (int)SocketError.ConnectionReset)
            {
                this.OnDisconnected(new AsyncSocketClientDisconnectedEventArgs(this._socketClient));
            }

            Debug.WriteLine(string.Format(AsyncSocketClientConstants.DebugStringFormat, e.Message));
            this.OnErrorOccurred(new AsyncSocketClientErrorOccurredEventArgs(e));
        }
    }
}
