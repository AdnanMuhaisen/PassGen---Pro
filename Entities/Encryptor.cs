using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PassGen___Pro
{
    internal class Encryptor
    {
        private static int EncryptionKey = 5;

        public static string EncryptString(string Str)
        {
            StringBuilder Sb = new StringBuilder(Str);
            for (int i = 0; i < Sb.Length; i++)
                Sb[i] = (char)((int)Sb[i] + EncryptionKey);
            return Sb.ToString();
        }

        public static string DecryptString(string Str)
        {
            StringBuilder Sb = new StringBuilder(Str);
            for (int i = 0; i < Sb.Length; i++)
                Sb[i] = (char)((int)Sb[i] - EncryptionKey);
            return Sb.ToString();
        }
    }
}
