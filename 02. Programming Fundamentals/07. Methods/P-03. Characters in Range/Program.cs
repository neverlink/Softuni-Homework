using System;

namespace P_03._Characters_in_Range
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char startChar = char.Parse(Console.ReadLine());
            char endChar = char.Parse(Console.ReadLine());

            PrintCharacters(startChar, endChar);
        }

        static void PrintCharacters(char startChar, char endChar)
        {
            if (startChar > endChar)
            {
                char temp = startChar;
                startChar = endChar;
                endChar = temp;
            }
            for (char i = ++startChar; i < endChar; i++)
            {
                Console.Write(i + " ");
            }
        }
    }
}
