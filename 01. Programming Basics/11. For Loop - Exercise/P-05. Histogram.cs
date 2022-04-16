using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P_05.Histogram
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberCount = int.Parse(Console.ReadLine());
            double p1 = 0;
            double p2 = 0;
            double p3 = 0;
            double p4 = 0;
            double p5 = 0;

            for (int i = 0; i < numberCount; i++)
            {
                int currentNumber = int.Parse(Console.ReadLine());
                if (currentNumber < 200)
                {
                    p1++;
                }
                else if (currentNumber >= 200 && currentNumber <= 399)
                {
                    p2++;
                }
                else if (currentNumber >= 400 && currentNumber <= 599)
                {
                    p3++;
                }
                else if (currentNumber >= 600 && currentNumber <= 799)
                {
                    p4++;
                }
                else if (currentNumber >= 800)
                {
                    p5++;
                }
            }
            p1 = p1 / numberCount * 100;
            p2 = p2 / numberCount * 100;
            p3 = p3 / numberCount * 100;
            p4 = p4 / numberCount * 100;
            p5 = p5 / numberCount * 100;
            Console.WriteLine($"{p1:F2}%");
            Console.WriteLine($"{p2:F2}%");
            Console.WriteLine($"{p3:F2}%");
            Console.WriteLine($"{p4:F2}%");
            Console.WriteLine($"{p5:F2}%");
        }
    }
}
