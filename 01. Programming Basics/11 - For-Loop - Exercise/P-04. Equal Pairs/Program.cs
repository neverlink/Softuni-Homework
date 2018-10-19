using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P_04.Equal_Pairs
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberCount = int.Parse(Console.ReadLine());
            int sum = 0;
            int diff = 0;
            int lastSum = 0;

            for (int i = 0; i < numberCount; i++)
            {
                int firstNumber = int.Parse(Console.ReadLine());
                int secondNumber = int.Parse(Console.ReadLine());
                sum = firstNumber + secondNumber;
                if (i > 0)
                {
                    diff = Math.Abs(lastSum - sum);
                }
                lastSum = sum;
            }
            if (diff == 0)
            {
                Console.WriteLine($"Yes, value={lastSum}");
            }
            else
            {
                Console.WriteLine($"No, maxdiff = {diff}");
            }
        }
    }
}
