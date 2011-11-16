//-----------------------------------------------------------------------
// <copyright file="AsyncSocketServerErrorCodeEnum.cs" company="GY Corporation">
//     Copyright (c) GY Corporation. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------
namespace AsyncSocket
{
    /// <summary>
    /// Async Socket Error Code Enum
    /// </summary>
    public enum AsyncSocketServerErrorCodeEnum
    {
        ServerStartFailure,
        ServerAcceptFailure,
        ClientSocketNoExist,
        ThrowSocketException
    };
}
