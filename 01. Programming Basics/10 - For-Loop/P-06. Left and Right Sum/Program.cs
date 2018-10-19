using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P_06.Left_and_Right_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            int count = int.Parse(Console.ReadLine());
            int leftSum = 0;
            int rightSum = 0;

            for (int i = 0; i < count; i++)
            {
                leftSum += int.Parse(Console.ReadLine());
            }
            for (int k = 0; k < count; k++)
            {
                rightSum += int.Parse(Console.ReadLine());
            }
            if (leftSum != rightSum)
            {
                Console.WriteLine($"No, diff = {Math.Abs(leftSum - rightSum)}");
            }
            else
            {
                Console.WriteLine($"Yes, sum = {leftSum}");
            }
        }
    }
}
