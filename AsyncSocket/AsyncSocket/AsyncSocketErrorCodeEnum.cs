//-----------------------------------------------------------------------
// <copyright file="AsyncSocketErrorCodeEnum.cs" company="GY Corporation">
//     Copyright (c) GY Corporation. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------
namespace AsyncSocket
{
    /// <summary>
    /// Async Socket Error Code Enum
    /// </summary>
    public enum AsyncSocketErrorCodeEnum
    {
        ServerStartFailure,
        ServerAcceptFailure,
        ClientSocketNoExist,
        ThrowSocketException
    };
}
