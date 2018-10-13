using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P_06.Account_Balance
{
    class Program
    {
        static void Main(string[] args)
        {
            int count = int.Parse(Console.ReadLine());
            double sum = 0;

            while (count > 0)
            {
                double input = double.Parse(Console.ReadLine());
                if (input < 0)
                {
                    Console.WriteLine("Invalid operation!");
                    break;
                }
                else
                {
                    sum += input;
                    Console.WriteLine($"Increase: {input:F2}");
                    count--;
                }
            }
            Console.WriteLine($"Total: {sum:F2}");
        }
    }
}
