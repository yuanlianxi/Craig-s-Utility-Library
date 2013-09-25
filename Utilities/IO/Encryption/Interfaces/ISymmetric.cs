﻿/*
Copyright (c) 2013 <a href="http://www.gutgames.com">James Craig</a>

Permission is hereby granted, free of charge, to any person obtaining a copy
of this software and associated documentation files (the "Software"), to deal
in the Software without restriction, including without limitation the rights
to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
copies of the Software, and to permit persons to whom the Software is
furnished to do so, subject to the following conditions:

The above copyright notice and this permission notice shall be included in
all copies or substantial portions of the Software.

THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN
THE SOFTWARE.*/

#region Usings
using System.Text;
using Utilities.IoC.Interfaces;
#endregion

namespace Utilities.IO.Encryption.Interfaces
{
    /// <summary>
    /// Symmetric encryption
    /// </summary>
    public interface ISymmetric
    {
        /// <summary>
        /// Name of the symmetric encryptor
        /// </summary>
        string Name { get; }

        /// <summary>
        /// Encrypts a byte array
        /// </summary>
        /// <param name="Data">Data to be encrypted</param>
        /// <param name="Key">Password to encrypt with</param>
        /// <param name="Salt">Salt to encrypt with</param>
        /// <param name="HashAlgorithm">Can be either SHA1 or MD5</param>
        /// <param name="PasswordIterations">Number of iterations to do</param>
        /// <param name="InitialVector">Needs to be 16 ASCII characters long</param>
        /// <param name="KeySize">Can be 64 (DES only), 128 (AES), 192 (AES and Triple DES), or 256 (AES)</param>
        /// <returns>An encrypted byte array</returns>
        byte[] Encrypt(this byte[] Data, string Key,
            string Salt = "Kosher",
            string HashAlgorithm = "SHA1",
            int PasswordIterations = 2,
            string InitialVector = "OFRna73m*aze01xY",
            int KeySize = 256);

        /// <summary>
        /// Decrypts a byte array
        /// </summary>
        /// <param name="Data">Data to be decrypted</param>
        /// <param name="Key">Password to decrypt with</param>
        /// <param name="AlgorithmUsing">Algorithm to use for decryption</param>
        /// <param name="Salt">Salt to decrypt with</param>
        /// <param name="HashAlgorithm">Can be either SHA1 or MD5</param>
        /// <param name="PasswordIterations">Number of iterations to do</param>
        /// <param name="InitialVector">Needs to be 16 ASCII characters long</param>
        /// <param name="KeySize">Can be 64 (DES only), 128 (AES), 192 (AES and Triple DES), or 256 (AES)</param>
        /// <returns>A decrypted byte array</returns>
        byte[] Decrypt(this byte[] Data, string Key,
            string Salt = "Kosher",
            string HashAlgorithm = "SHA1",
            int PasswordIterations = 2,
            string InitialVector = "OFRna73m*aze01xY",
            int KeySize = 256);
    }
}