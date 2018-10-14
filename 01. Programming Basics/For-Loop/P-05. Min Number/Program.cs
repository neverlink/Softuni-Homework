using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P_05.Min_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            int count = int.Parse(Console.ReadLine());
            int smallestNumber = int.MaxValue;

            for (int i = 0; i < count; i++)
            {
                int currentNumber = int.Parse(Console.ReadLine());
                if (currentNumber < smallestNumber)
                {
                    smallestNumber = currentNumber;
                }
            }
            Console.WriteLine(smallestNumber);
        }
    }
}
