using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P_05.Coins
{
    class Program
    {
        static void Main(string[] args)
        {
            double input = double.Parse(Console.ReadLine());
            double cents = input - Math.Truncate(input);
            int coinsCount = 0;

            input *= 100;

            while (input - 200 >= 0)
            {
                input -= 200;
                coinsCount++;
            }
            while (input - 100 >= 0)
            {
                input -= 100;
                coinsCount++;
            }
            while (input - 50 >= 0)
            {
                input -= 50;
                coinsCount++;
            }
            while (input - 20 >= 0)
            {
                input -= 20;
                coinsCount++;
            }
            while (input - 10 >= 0)
            {
                input -= 10;
                coinsCount++;
            }
            while (input - 5 >= 0)
            {
                input -= 5;
                coinsCount++;
            }
            while (input - 2 >= 0)
            {
                input -= 2;
                coinsCount++;
            }
            while (input - 1 >= 0)
            {
                input -= 1;
                coinsCount++;
            }

            Console.WriteLine(coinsCount);
        }
    }
}
