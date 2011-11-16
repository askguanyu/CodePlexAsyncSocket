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
        /// <param name="exception">AsyncSocket Exception</param>
        public AsyncSocketServerErrorEventArgs(AsyncSocketServerException exception)
        {
            this.Exception = exception;
        }

        /// <summary>
        /// Gets or sets AsyncSocket Exception
        /// </summary>
        public AsyncSocketServerException Exception
        {
            get;
            set;
        }
    }
}
