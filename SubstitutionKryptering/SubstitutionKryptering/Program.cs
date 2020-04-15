using System;
using System.Diagnostics;
using System.Security.Cryptography;

namespace SubstitutionKryptering
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Type some text to be encrypted");
            string TextToEncrypt = Console.ReadLine();
            Console.WriteLine("");


            TextToEncrypt = Encrypter.Encryption(TextToEncrypt);
            Console.WriteLine("Encrypted Text: {0}", TextToEncrypt);

            string TextToDecrypt = Encrypter.Decryption(TextToEncrypt);
            Console.WriteLine("Decrypted Text: {0}", TextToDecrypt);

            Console.ReadLine();
            Console.Clear();

            Stopwatch stopw = new Stopwatch();
            stopw.Start();

            //RNGCryptoServiceProvider tal
            Console.WriteLine("RNGCryptoServiceProvider");
            using (RNGCryptoServiceProvider rng = new RNGCryptoServiceProvider())
            {
                byte[] rngData = new byte[4];
                for (int i = 0; i < 1000; i++)
                {

                    rng.GetBytes(rngData);

                    //convert to int 32
                    int value = BitConverter.ToInt32(rngData, 0);
                    Console.Write(value + " , ");

                }

            }
            stopw.Stop();

            //udskriv antal milisekunder der blev brugt på udførelse
            TimeSpan time1 = stopw.Elapsed;
            Console.WriteLine("");
            Console.WriteLine("RNG {0}ms.", time1.TotalMilliseconds);
            Console.WriteLine("");



            //Random tal
            stopw.Start();

            Random randomNr = new Random();
            Console.WriteLine("Random Numbers");
            for (int i = 0; i < 1000; i++)
            {
                Console.Write(randomNr.Next(-1000000000, 1000000000) + " , ");
            }

            //udskriv antal milisekunder der blev brugt på udførelse
            stopw.Stop();
            TimeSpan time2 = stopw.Elapsed;
            Console.WriteLine("");
            Console.WriteLine("Random {0}ms.", time2.TotalMilliseconds);

            Console.ReadLine();

        }
    }
}
