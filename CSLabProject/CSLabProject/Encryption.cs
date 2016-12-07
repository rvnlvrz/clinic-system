using System;
using System.Text;
using System.Security.Cryptography;
using System.IO;

namespace CSLabProject
{
    /// <summary>
    /// This class manages en/decryption using Rijndael crypto
    /// </summary>
    public static class Encrypt
    {
        // the IV size in bytes must be (keysize/2)
        // in conversion, a 16 character string will give us 32 bytse
        private const string stringIV = "!aKsMt*-*%q1bc=a";
        private const int keySize = 256;

        /// <summary>
        /// Processes input strings and obfuscates them so that they can be safely stored in plain text
        /// </summary>
        /// <param name="userName">User provided username</param>
        /// <param name="passCode">User provided passphrase</param>
        /// <returns>Returns an encrypted base 64 string</returns>
        //Encrypt
        public static string EncryptString(string userName, string passCode)
        {
            byte[] ivByte = Encoding.UTF8.GetBytes(stringIV);
            byte[] userByte = Encoding.UTF8.GetBytes(userName);

            PasswordDeriveBytes passwd = new PasswordDeriveBytes(passCode, null); // non salted

            byte[] keyByte = passwd.GetBytes(keySize / 8);
            RijndaelManaged symmetricKey = new RijndaelManaged();
            symmetricKey.Mode = CipherMode.CBC;

            ICryptoTransform encryptor = symmetricKey.CreateEncryptor(keyByte, ivByte);
            MemoryStream memStream = new MemoryStream();
            CryptoStream cryptStream = new CryptoStream(memStream, encryptor, CryptoStreamMode.Write);
            cryptStream.Write(userByte, 0, userByte.Length);
            cryptStream.FlushFinalBlock();

            byte[] ciperByte = memStream.ToArray();
            memStream.Close();
            cryptStream.Close();

            return Convert.ToBase64String(ciperByte);
        }

       
    }
}