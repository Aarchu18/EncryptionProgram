using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EncryptionProgram
{
    class Program
    {
        public static char cipher(char ch, int key)
        {
            if (!char.IsLetter(ch))
            {

                return ch;
            }

            char d = char.IsUpper(ch) ? 'A' : 'a';
            return (char)((((ch + key) - d) % 26) + d);
        }
        public static string Encrypt(string input, int key)
        {
            string output = string.Empty;

            foreach (char ch in input)
                output += cipher(ch, key);

            return output;
        }

        public static string Decrypt(string input, int key)
        {
            return Encrypt(input, 26 - key);
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Enter your string to encrypt");
            string userString = Console.ReadLine();

            Console.WriteLine("\n");

            Console.WriteLine("Enter Your Key");
            int key = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("\n");

            Console.WriteLine("Encrypted Data");

            string cipherText = Encrypt(userString, key);
            Console.WriteLine(cipherText);
            Console.Write("\n");

            Console.WriteLine("Decrypted Data:");

            string t = Decrypt(cipherText, key);
            Console.WriteLine(t);
            Console.Write("\n");




            Console.ReadKey();

        }
    }
}
