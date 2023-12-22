using System;

namespace P_06._Strong_number
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string number = Console.ReadLine();
            int totalSumFactorial = 0;

            for (int i = 0; i < number.Length; i++)
            {
                char currentChar = number[i];
                int currentDigit = currentChar - '0';
                
                int sumFactorial = 1;
                for (int digitIndex = 1; digitIndex <= currentDigit; digitIndex++)
                {
                    sumFactorial *= digitIndex;
                }
                totalSumFactorial += sumFactorial;
            }


            if (totalSumFactorial == int.Parse(number))
            {
                Console.WriteLine("yes");
            }
            else
            {
                Console.WriteLine("no");
            }
        }
    }
}
