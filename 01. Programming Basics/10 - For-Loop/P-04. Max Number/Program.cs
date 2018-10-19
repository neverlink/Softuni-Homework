using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P_04.Max_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            int count = int.Parse(Console.ReadLine());
            int largestNumber = int.MinValue;

            for (int i = 0; i < count; i++)
            {
                int currentNumber = int.Parse(Console.ReadLine());
                if (currentNumber > largestNumber)
                {
                    largestNumber = currentNumber;
                }
            }
            Console.WriteLine(largestNumber);
        }
    }
}
