using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P_03.Odd_or_Even_Position
{
    class Program
    {
        static void Main(string[] args)
        {
            double oddSum = 0;
            double oddMin = double.MaxValue;
            double oddMax = double.MinValue;

            double evenSum = 0;
            double evenMin = double.MaxValue;
            double evenMax = double.MinValue;

            int count = int.Parse(Console.ReadLine());

            for (int i = 1; i <= count; i++)
            {
                double currentNumber = double.Parse(Console.ReadLine());
                if (i % 2 != 0)
                {
                    if (currentNumber >= oddMax)
                    {
                        oddMax = currentNumber;
                    }
                    if (currentNumber <= oddMin)
                    {
                        oddMin = currentNumber;
                    }
                    oddSum += currentNumber;
                }
                else
                {
                    if (currentNumber >= evenMax)
                    {
                        evenMax = currentNumber;
                    }
                    if (currentNumber <= evenMin)
                    {
                        evenMin = currentNumber;
                    }
                    evenSum += currentNumber;
                }
            }
            Console.WriteLine($"OddSum={oddSum},");
            if (oddMin == double.MaxValue)
            {
                Console.WriteLine($"OddMin=No,");
            }
            else
            {
                Console.WriteLine($"OddMin={oddMin},");
            }
            if (oddMax == double.MinValue)
            {
                Console.WriteLine($"OddMax=No,");
            }
            else
            {
                Console.WriteLine($"OddMax={oddMax},");
            }
            Console.WriteLine($"EvenSum={evenSum},");
            if (evenMin == double.MaxValue)
            {
                Console.WriteLine($"EvenMin=No,");
            }
            else
            {
                Console.WriteLine($"EvenMin={evenMin},");
            }
            if (evenMax == double.MinValue)
            {
                Console.WriteLine($"EvenMax=No,");
            }
            else
            {
                Console.WriteLine($"EvenMax={evenMax}");
            }
        }
    }
}
