//-----------------------------------------------------------------------
// <copyright file="AsyncSocketErrorEventArgs.cs" company="GY Corporation">
//     Copyright (c) GY Corporation. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------
namespace AsyncSocket
{
    using System;

    /// <summary>
    /// Async Socket Error EventArgs Class
    /// </summary>
    public class AsyncSocketErrorEventArgs : EventArgs
    {
        /// <summary>
        /// Constructor of AsyncSocketErrorEventArgs
        /// </summary>
        /// <param name="exception">AsyncSocket Exception</param>
        public AsyncSocketErrorEventArgs(AsyncSocketException exception)
        {
            this.Exception = exception;
        }

        /// <summary>
        /// Gets or sets AsyncSocket Exception
        /// </summary>
        public AsyncSocketException Exception
        {
            get;
            set;
        }
    }
}
