using System;

namespace P_04._Print_and_Sum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int seqStart = int.Parse(Console.ReadLine());
            int seqEnd = int.Parse(Console.ReadLine());

            string seqString = String.Empty;
            int sum = 0;

            for (int i = seqStart; i <= seqEnd; i++)
            {
                seqString += i + " ";
                sum += i;
            }
            Console.WriteLine(seqString);
            Console.WriteLine($"Sum: {sum}");
        }
    }
}
