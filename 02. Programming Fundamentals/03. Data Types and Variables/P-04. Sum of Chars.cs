using System;

namespace P_04._Sum_of_Chars
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int sum = 0;
            int linesToRead = int.Parse(Console.ReadLine());

            for (int i = 0; i < linesToRead; i++)
            {
                sum += char.Parse(Console.ReadLine());
            }
            Console.WriteLine($"The sum equals: {sum}");
        }
    }
}
