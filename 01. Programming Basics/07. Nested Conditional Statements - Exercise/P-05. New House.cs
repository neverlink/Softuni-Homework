using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P_05.New_House
{
    class Program
    {
        static void Main(string[] args)
        {
            string flowerType = Console.ReadLine();
            int count = int.Parse(Console.ReadLine());
            int budget = int.Parse(Console.ReadLine());
            double sum = 0;

            if (flowerType == "Roses")
            {
                sum = 5.00 * count;
                if (count > 80)
                {
                    sum *= 0.9;
                }
            }
            else if (flowerType == "Dahlias")
            {
                sum = 3.80 * count;
                if (count > 90)
                {
                    sum *= 0.85;
                }
            }
            else if (flowerType == "Tulips")
            {
                sum = 2.80 * count;
                if (count > 80)
                {
                    sum *= 0.85;
                }
            }
            else if (flowerType == "Narcissus")
            {
                sum = 3 * count;
                if (count < 120)
                {
                    sum *= 1.15;
                }
            }
            else
            {
                sum = 2.5 * count;
                if (count < 80)
                {
                    sum *= 1.2;
                }
            }
            if (budget >= sum)
            {
                Console.WriteLine($"Hey, you have a great garden with {count} {flowerType} and {budget - sum:F2} leva left.");
            }
            else
            {
                Console.WriteLine($"Not enough money, you need {sum - budget:F2} leva more.");
            }
        }
    }
}
