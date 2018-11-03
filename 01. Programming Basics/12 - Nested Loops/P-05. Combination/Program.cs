using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P_05.Combination
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            int combinationCount = 0;

            for (int num1 = 0; num1 <= number; num1++)
            {
                for (int num2 = 0; num2 <= number; num2++)
                {
                    for (int num3 = 0; num3 <= number; num3++)
                    {
                        for (int num4 = 0; num4 <= number; num4++)
                        {
                            for (int num5 = 0; num5 <= number; num5++)
                            {
                                if (num1 + num2 + num3 + num4 + num5 == number)
                                {
                                    combinationCount++;
                                }
                            }
                        }
                    }
                }
            }
            Console.WriteLine(combinationCount);
        }
    }
}
