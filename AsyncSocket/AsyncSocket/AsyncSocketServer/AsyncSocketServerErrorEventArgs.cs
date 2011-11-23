//-----------------------------------------------------------------------
// <copyright file="AsyncSocketServerErrorEventArgs.cs" company="GY Corporation">
//     Copyright (c) GY Corporation. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------
namespace AsyncSocket
{
    using System;

    /// <summary>
    /// Async Socket Error EventArgs Class
    /// </summary>
    public class AsyncSocketServerErrorEventArgs : EventArgs
    {
        /// <summary>
        /// Constructor of AsyncSocketErrorEventArgs
        /// </summary>
        public AsyncSocketServerErrorEventArgs() : this(string.Empty, null) { }

        /// <summary>
        /// Constructor of AsyncSocketErrorEventArgs
        /// </summary>
        /// <param name="message">Error Message</param>
        /// <param name="exception">Exception object</param>
        /// <param name="errorCode">AsyncSocketServerErrorCodeEnum</param>
        public AsyncSocketServerErrorEventArgs(string message, Exception exception, AsyncSocketServerErrorCodeEnum errorCode = AsyncSocketServerErrorCodeEnum.ThrowSocketException)
        {
            this.Message = message;
            this.Exception = exception;
            this.ErrorCode = errorCode;
        }

        /// <summary>
        /// Gets or sets Error Message
        /// </summary>
        public string Message
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets Exception
        /// </summary>
        public Exception Exception
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets Error Code
        /// </summary>
        public AsyncSocketServerErrorCodeEnum ErrorCode
        {
            get;
            set;
        }
    }
}
