using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P_06.Cake
{
    class Program
    {
        static void Main(string[] args)
        {
            double cakeWidth = double.Parse(Console.ReadLine());
            double cakeHeight = double.Parse(Console.ReadLine());
            double cakeSize = cakeWidth * cakeHeight;

            string input = Console.ReadLine();

            while (input != "STOP" && cakeSize >= 0)
            {
                cakeSize -= double.Parse(input);
                if (cakeSize < 0)
                {
                    Console.WriteLine($"No more cake left! You need {Math.Abs(cakeSize)} pieces more.");
                }
                input = Console.ReadLine();
            }

            if (cakeSize >= 0)
            {
                Console.WriteLine($"{cakeSize} pieces are left.");
            }
        }
    }
}
