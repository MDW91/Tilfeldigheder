using System;
using System.Collections.Generic;
using System.Text;

namespace SubstitutionKryptering
{
    class Encrypter
    {

        //Encrypter text
        public static string Encryption(string text)
        {
            int letterInt = 0;
            char letter = ' ';
            string Encryptedtext = "";
            for (int i = 0; i < text.Length; i++)
            {
                letterInt = (int)text[i] + 1;
                letter = (char)letterInt;
                Encryptedtext += letter.ToString();
            }
            return Encryptedtext;
        }

        //Decrypter text
        public static string Decryption(string text)
        {
            int letterInt = 0;
            char letter = ' ';
            string Decryptedtext = "";
            for (int i = 0; i < text.Length; i++)
            {
                letterInt = (int)text[i] - 1;
                letter = (char)letterInt;
                Decryptedtext += letter.ToString();
            }
            return Decryptedtext;
        }

    }        

}
