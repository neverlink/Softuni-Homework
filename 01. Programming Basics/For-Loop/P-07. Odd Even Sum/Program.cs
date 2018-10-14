using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P_07.Odd_Even_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            int count = int.Parse(Console.ReadLine());
            int oddSum = 0;
            int evenSum = 0;

            for (int i = 0; i < count; i++)
            {
                if (i % 2 == 0)
                {
                    evenSum += int.Parse(Console.ReadLine());
                }
                else
                {
                    oddSum += int.Parse(Console.ReadLine());
                }
            }
            if (oddSum != evenSum)
            {
                Console.WriteLine($"No, diff = {Math.Abs(oddSum - evenSum)}");
            }
            else
            {
                Console.WriteLine($"Yes, sum = {oddSum}");
            }
        }
    }
}
