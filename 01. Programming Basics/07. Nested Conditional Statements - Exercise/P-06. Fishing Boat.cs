using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P_06.Fishing_Boat
{
    class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            string season = Console.ReadLine();
            int fishers = int.Parse(Console.ReadLine());
            double boatPrice = 0;

            if (season == "Spring")
            {
                boatPrice = 3000;
                if (fishers <= 6)
                {
                    boatPrice *= 0.9;
                }
                else if (fishers >= 7 && fishers <= 11)
                {
                    boatPrice *= 0.85;
                }
                else
                {
                    boatPrice *= 0.75;
                }
            }
            else if (season == "Summer" || season == "Autumn")
            {
                boatPrice = 4200;
                if (fishers <= 6)
                {
                    boatPrice *= 0.9;
                }
                else if (fishers >= 7 && fishers <= 11)
                {
                    boatPrice *= 0.85;
                }
                else
                {
                    boatPrice *= 0.75;
                }
            }
            else if (season == "Winter")
            {
                boatPrice = 2600;
                if (fishers <= 6)
                {
                    boatPrice *= 0.9;
                }
                else if (fishers >= 7 && fishers <= 11)
                {
                    boatPrice *= 0.85;
                }
                else
                {
                    boatPrice *= 0.75;
                }
            }
            else
            {

            }
            if (season != "Autumn" && fishers % 2 == 0)
            {
                boatPrice *= 0.95;
            }
            else
            {

            }
            if (budget >= boatPrice)
            {
                Console.WriteLine($"Yes! You have {budget - boatPrice:F2} leva left.");
            }
            else
            {
                Console.WriteLine($"Not enough money! You need {boatPrice - budget:F2} leva.");
            }
        }
    }
}
