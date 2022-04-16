using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P_05.Walking
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            int stepSum = 0;
            while (input != "Going home")
            {
                if (stepSum >= 10000)
                {
                    Console.WriteLine("Goal reached! Good job!");
                    break;
                }
                else
                {
                    stepSum += int.Parse(input);
                }
                input = Console.ReadLine();
            }
            if (stepSum < 10000)
            {
                stepSum += int.Parse(Console.ReadLine());
                if (stepSum < 10000)
                {
                    Console.WriteLine($"{10000 - stepSum} more steps to reach goal.");
                }
                else
                {
                    Console.WriteLine("Goal reached! Good job!");
                }
            }
        }
    }
}
