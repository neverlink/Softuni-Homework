using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P_04.Number_sequence
{
    class Program
    {
        static void Main(string[] args)
        {
            int smallestNumber = int.MaxValue;
            int largestNumber = int.MinValue;

            string input = Console.ReadLine();

            while (input != "END")
            {
                int number = int.Parse(input);

                if (number <= smallestNumber)
                {
                    smallestNumber = number;
                }
                if (number >= largestNumber)
                {
                    largestNumber = number;
                }
                input = Console.ReadLine();
            }
            Console.WriteLine($"Max number: {largestNumber}");
            Console.WriteLine($"Min number: {smallestNumber}");
        }
    }
}
