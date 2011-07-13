//-----------------------------------------------------------------------
// <copyright file="AsyncSocketException.cs" company="GY Corporation">
//     Copyright (c) GY Corporation. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------
namespace AsyncSocket
{
    using System;
    using System.Net.Sockets;
    using System.Runtime.Serialization;

    /// <summary>
    /// AsyncSocket Exception Class
    /// </summary>
    [Serializable]
    public class AsyncSocketException : Exception
    {
        /// <summary>
        ///
        /// </summary>
        /// <param name="message"></param>
        /// <param name="socketException"></param>
        public AsyncSocketException(string message, SocketException socketException) :
            base(String.Format("{0} - {1}", message, AsyncSocketConstants.AsyncSocketException), socketException)
        {
            this.ErrorCode = AsyncSocketErrorCodeEnum.ThrowSocketException;
        }

        /// <summary>
        ///
        /// </summary>
        /// <param name="message"></param>
        /// <param name="errorCode"></param>
        public AsyncSocketException(string message, AsyncSocketErrorCodeEnum errorCode) :
            base(String.Format("{0} - {1}", message, AsyncSocketConstants.AsyncSocketException))
        {
            this.ErrorCode = errorCode;
        }

        /// <summary>
        /// Gets AsyncSocket ErrorCode
        /// </summary>
        public AsyncSocketErrorCodeEnum ErrorCode
        {
            get;
            private set;
        }

        /// <summary>
        ///
        /// </summary>
        /// <param name="info"></param>
        /// <param name="context"></param>
        public override void GetObjectData(SerializationInfo info, StreamingContext context)
        {
            base.GetObjectData(info, context);
        }
    }
}
