using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P_02.Half_Sum_Element
{
    class Program
    {
        static void Main(string[] args)
        {
            int count = int.Parse(Console.ReadLine());
            int largestNumber = int.MinValue;
            int sum = 0;

            for (int i = 0; i < count; i++)
            {
                int currentNumber = int.Parse(Console.ReadLine());
                sum += currentNumber;
                if (currentNumber >= largestNumber)
                {
                    largestNumber = currentNumber;
                }
            }

            sum -= largestNumber;

            if (sum == largestNumber)
            {
                Console.WriteLine("Yes");
                Console.WriteLine($"Sum = {sum}");
            }
            else
            {
                Console.WriteLine("No");
                Console.WriteLine($"Diff = {Math.Abs(sum - largestNumber)}");
            }
        }
    }
}
