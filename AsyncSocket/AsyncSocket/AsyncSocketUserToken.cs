﻿//-----------------------------------------------------------------------
// <copyright file="AsyncSocketUserToken.cs" company="GY Corporation">
//     Copyright (c) GY Corporation. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------
namespace AsyncSocket
{
    using System;
    using System.Net;
    using System.Net.Sockets;

    /// <summary>
    /// This class is designed for use as the object to be assigned to the SocketAsyncEventArgs.UserToken property.
    /// </summary>
    public class AsyncSocketUserToken : EventArgs
    {
        /// <summary>
        ///
        /// </summary>
        private Socket _socket;

        /// <summary>
        /// Constructor of AsyncUserToken
        /// </summary>
        public AsyncSocketUserToken() : this(null) { }

        /// <summary>
        /// Constructor of AsyncUserToken
        /// </summary>
        /// <param name="socket">Socket context</param>
        public AsyncSocketUserToken(Socket socket)
        {
            this.ReadEventArgs = new SocketAsyncEventArgs();
            this.ReadEventArgs.UserToken = this;
            if (null != socket)
            {
                this._socket = socket;
            }
        }

        /// <summary>
        /// Gets or sets SocketAsyncEventArgs
        /// </summary>
        public SocketAsyncEventArgs ReadEventArgs
        {
            get;
            set;
        }

        /// <summary>
        /// Gets length of received data bytes
        /// </summary>
        public int BytesReceived
        {
            get;
            private set;
        }

        /// <summary>
        /// Gets offset of buffer
        /// </summary>
        public int Offset
        {
            get;
            private set;
        }

        /// <summary>
        /// Gets received buffer
        /// </summary>
        public byte[] ReceivedBuffer
        {
            get;
            private set;
        }

        /// <summary>
        /// Gets received raw Data
        /// </summary>
        public byte[] Data
        {
            get
            {
                byte[] data = new byte[this.BytesReceived];
                Array.Copy(this.ReceivedBuffer, this.Offset, data, 0, this.BytesReceived);
                return data;
            }
        }

        /// <summary>
        /// Gets or sets user defined operation flag
        /// </summary>
        public object Operation
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets socket context
        /// </summary>
        public Socket Socket
        {
            get
            {
                return _socket;
            }

            set
            {
                if (value != null)
                {
                    _socket = value;
                    this.EndPoint = (IPEndPoint)_socket.RemoteEndPoint;
                }
            }
        }

        /// <summary>
        /// Gets or sets connection Id
        /// </summary>
        public Guid ConnectionId
        {
            get;
            set;
        }

        /// <summary>
        /// Gets connected client EndPoint
        /// </summary>
        public IPEndPoint EndPoint
        {
            get;
            private set;
        }

        /// <summary>
        /// Set BytesReceived
        /// </summary>
        /// <param name="bytesReceived">Bytes Received</param>
        public void SetBytesReceived(int bytesReceived)
        {
            this.BytesReceived = bytesReceived;
        }

        /// <summary>
        /// Set Buffer
        /// </summary>
        /// <param name="buffer">buffer</param>
        public void SetBuffer(byte[] buffer, int offset)
        {
            this.ReceivedBuffer = buffer;
            this.Offset = offset;
            this.BytesReceived = 0;
        }
    }
}
