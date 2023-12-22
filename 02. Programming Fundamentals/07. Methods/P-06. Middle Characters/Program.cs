using System;

namespace P_06._Middle_Characters
{
    internal class Program
    {
        static void Main(string[] args)
        {
            PrintMiddleChar(Console.ReadLine());
        }

        static void PrintMiddleChar(string text)
        {
            if (text.Length % 2 == 0)
            {
                Console.Write(text[text.Length / 2 - 1]);
                Console.Write(text[text.Length / 2]);
                return;
            }
            Console.WriteLine(text[text.Length / 2]);
        }
    }
}