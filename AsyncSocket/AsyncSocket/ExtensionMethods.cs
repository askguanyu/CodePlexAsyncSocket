//-----------------------------------------------------------------------
// <copyright file="ExtensionMethods.cs" company="Contoso Corporation">
//     Copyright (c) Contoso Corporation. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------
namespace AsyncSocket
{
    using System;
    using System.Text;
    using System.Text.RegularExpressions;

    /// <summary>
    /// Extension Methods
    /// </summary>
    public static class ExtensionMethods
    {
        /// <summary>
        /// Convert Hex string to bytes
        /// </summary>
        /// <param name="data">Hex string</param>
        /// <returns>bytes</returns>
        public static byte[] ToHexByte(this string data)
        {
            string hexPattern = "^[0-9a-fA-F]+$";

            string temp = data.Trim(new char[] { ' ', '\n', '\r' });

            if (Regex.IsMatch(temp, hexPattern))
            {
                if (data.Length % 2 == 1)
                {
                    temp = "0" + temp;
                }

                int length = temp.Length / 2;
                byte[] result = new byte[length];

                for (int i = 0; i < length; i++)
                {
                    result[i] = Convert.ToByte(temp.Substring(i * 2, 2), 16);
                }

                return result;
            }
            else
            {
                throw new ArgumentOutOfRangeException(data, string.Format("\"{0}\" is not a Hex String.", data));
            }
        }

        /// <summary>
        /// Convert bytes to Hex string
        /// </summary>
        /// <param name="data">bytes</param>
        /// <param name="addSpace">Whether add space between Hex</param>
        /// <returns>Hex string</returns>
        public static string ToHexString(this byte[] data, bool addSpace = true)
        {
            StringBuilder result = new StringBuilder();

            if (addSpace)
            {
                for (int i = 0; i < data.Length; i++)
                {
                    result.Append(Convert.ToString(data[i], 16).PadLeft(2, '0'));
                    result.Append(" ");
                }
            }
            else
            {
                for (int i = 0; i < data.Length; i++)
                {
                    result.Append(Convert.ToString(data[i], 16).PadLeft(2, '0'));
                }
            }

            return result.ToString().Trim();
        }

        /// <summary>
        /// Convert byte to Hex char
        /// </summary>
        /// <param name="data">byte</param>
        /// <returns>Hex char</returns>
        public static string ToHexString(this byte data)
        {
            return Convert.ToString(data, 16).PadLeft(2, '0');
        }
    }
}
