//-----------------------------------------------------------------------
// <copyright file="AsyncSocketServerException.cs" company="GY Corporation">
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
    public class AsyncSocketServerException : Exception
    {
        /// <summary>
        ///
        /// </summary>
        /// <param name="message"></param>
        /// <param name="socketException"></param>
        public AsyncSocketServerException(string message, SocketException socketException) :
            base(String.Format("{0} - {1}", message, AsyncSocketServerConstants.AsyncSocketException), socketException)
        {
            this.ErrorCode = AsyncSocketServerErrorCodeEnum.ThrowSocketException;
        }

        /// <summary>
        ///
        /// </summary>
        /// <param name="message"></param>
        /// <param name="errorCode"></param>
        public AsyncSocketServerException(string message, AsyncSocketServerErrorCodeEnum errorCode) :
            base(String.Format("{0} - {1}", message, AsyncSocketServerConstants.AsyncSocketException))
        {
            this.ErrorCode = errorCode;
        }

        /// <summary>
        /// Gets AsyncSocket ErrorCode
        /// </summary>
        public AsyncSocketServerErrorCodeEnum ErrorCode
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
