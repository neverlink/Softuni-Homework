using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P_04.Wedding_Decoration
{
    class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            string input = Console.ReadLine();
            double total = 0.00;
            int balloonsCount = 0;
            int flowersCount = 0;
            int candlesCount = 0;
            int ribbonLength = 0;

            while (input != "stop" && budget > total)
            {
                string productType = input;
                int count = int.Parse(Console.ReadLine());
                switch (productType)
                {
                    case "balloons":
                        total += 0.10 * count;
                        balloonsCount += count;
                        break;
                    case "flowers":
                        total += 1.5 * count;
                        flowersCount += count;
                        break;
                    case "candles":
                        total += 0.5 * count;
                        candlesCount += count;
                        break;
                    case "ribbon":
                        total += 2 * count;
                        ribbonLength += count;
                        break;
                    default:
                        break;
                }
                input = Console.ReadLine();
            }
            if (budget > total)
            {
                Console.WriteLine($"Spend money: {total:F2}");
                Console.WriteLine($"Money left: {budget - total:F2}");
            }
            else
            {
                Console.WriteLine("All money is spent!");
            }
            Console.WriteLine($"Purchased decoration is {balloonsCount} balloons, {ribbonLength} m ribbon, {flowersCount} flowers and {candlesCount} candles.");
        }
    }
}
