using System;
using System.Text;

namespace P_04._Caesar_Cipher
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string strToEncrypt = Console.ReadLine();
            Console.WriteLine(Encrypt(strToEncrypt));
        }

        static string Encrypt(string input)
        {
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < input.Length; i++)
            {
                sb.Append((char)(input[i] + 3));
            }
            return sb.ToString();
        }
    }
}
