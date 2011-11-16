//-----------------------------------------------------------------------
// <copyright file="AsyncSocketClientEventArgs.cs" company="GY Corporation">
//     Copyright (c) GY Corporation. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------
namespace AsyncSocket
{
    using System;
    using System.Net.Sockets;

    /// <summary>
    /// AsyncSocketClient Connected EventArgs
    /// </summary>
    public class AsyncSocketClientConnectedEventArgs : EventArgs
    {
        /// <summary>
        /// Constructor of AsyncSocketClientConnectedEventArgs
        /// </summary>
        /// <param name="socket">Connected socket token</param>
        public AsyncSocketClientConnectedEventArgs(Socket socket)
        {
            this.SocketToken = socket;
        }

        /// <summary>
        /// Gets socket token
        /// </summary>
        public Socket SocketToken
        {
            get;
            private set;
        }
    }

    /// <summary>
    /// AsyncSocketClient Disconnected EventArgs
    /// </summary>
    public class AsyncSocketClientDisconnectedEventArgs : EventArgs
    {
        /// <summary>
        /// Constructor of AsyncSocketClientDisconnectedEventArgs
        /// </summary>
        /// <param name="socket">Disconnected socket token</param>
        public AsyncSocketClientDisconnectedEventArgs(Socket socket)
        {
            this.SocketToken = socket;
        }

        /// <summary>
        /// Gets socket token
        /// </summary>
        public Socket SocketToken
        {
            get;
            private set;
        }
    }

    /// <summary>
    /// AsyncSocketClient DataReceived EventArgs
    /// </summary>
    public class AsyncSocketClientDataReceivedEventArgs : EventArgs
    {
        /// <summary>
        /// Constructor of AsyncSocketClientDataReceivedEventArgs
        /// </summary>
        /// <param name="socket">Socket token</param>
        /// <param name="receivedRawData">Received data</param>
        public AsyncSocketClientDataReceivedEventArgs(Socket socket, byte[] receivedRawData)
        {
            this.SocketToken = socket;
            this.ReceivedRawData = receivedRawData;
        }

        /// <summary>
        /// Gets received data
        /// </summary>
        public byte[] ReceivedRawData
        {
            get;
            private set;
        }

        /// <summary>
        /// Gets socket token
        /// </summary>
        public Socket SocketToken
        {
            get;
            private set;
        }
    }

    /// <summary>
    /// AsyncSocketClient ErrorOccurred EventArgs
    /// </summary>
    public class AsyncSocketClientErrorOccurredEventArgs : EventArgs
    {
        /// <summary>
        /// Constructor of AsyncSocketClientErrorOccurredEventArgs
        /// </summary>
        /// <param name="e">Socket exception</param>
        public AsyncSocketClientErrorOccurredEventArgs(SocketException e)
        {
            this.Exception = e;
        }

        /// <summary>
        /// Gets socket exception
        /// </summary>
        public SocketException Exception
        {
            get;
            private set;
        }
    }
}
