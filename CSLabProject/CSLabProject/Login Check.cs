using System;
using System.Text;
using System.Security.Cryptography;
using System.IO;

namespace CSLabProject
{
    public static class Encrypt
    {
        // the IV size in bytes must be (keysize/2)
        // in conversion, a 16 character string will give us 32 bytse
        private const string stringIV = "!aKsMt*-*%q1bc=a";

        private const int keySize = 256;

        //Encrypt
        public static string EncryptString(string userName, string passCode)
        {
            byte[] uNameByte = Encoding.UTF8.GetBytes(stringIV);
            byte[] passByte = Encoding.UTF8.GetBytes(userName);

            PasswordDeriveBytes passwd = new PasswordDeriveBytes(passCode, null); // non salted

            byte[] keyByte = passwd.GetBytes(keySize / 8);
            RijndaelManaged symmetricKey = new RijndaelManaged();
            symmetricKey.Mode = CipherMode.CBC;

            ICryptoTransform encryptor = symmetricKey.CreateEncryptor(keyByte, uNameByte);
            MemoryStream memStream = new MemoryStream();
            CryptoStream cryptStream = new CryptoStream(memStream, encryptor, CryptoStreamMode.Write);
            cryptStream.Write(uNameByte, 0, uNameByte.Length);
            cryptStream.FlushFinalBlock();

            byte[] ciperByte = memStream.ToArray();
            memStream.Close();
            cryptStream.Close();

            return Convert.ToBase64String(ciperByte);        
        }
    }
}