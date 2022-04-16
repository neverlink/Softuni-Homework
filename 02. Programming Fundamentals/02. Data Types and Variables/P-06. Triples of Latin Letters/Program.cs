using System;

namespace P_06._Triples_of_Latin_Letters
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int endLetter = 'a' + int.Parse(Console.ReadLine());
            for (char i = 'a'; i < endLetter; i++)
            {
                for (char j = 'a'; j < endLetter; j++)
                {
                    for (char k = 'a'; k < endLetter; k++)
                    {
                        Console.WriteLine($"{i}{j}{k}");
                    }
                }
            }
        }
    }
}
