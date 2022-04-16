using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P_08.Journey
{
    class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            string season = Console.ReadLine();
            double expenses = 0;

            if (budget <= 100)
            {
                Console.WriteLine($"Somewhere in Bulgaria");
                if (season == "summer")
                {
                    expenses = budget * 0.30;
                    Console.WriteLine($"Camp - {expenses:F2}");
                }
                else if (season == "winter")
                {
                    expenses = budget * 0.70;
                    Console.WriteLine($"Hotel - {expenses:F2}");
                }
            }
            else if (budget > 100 && budget <= 1000)
            {
                Console.WriteLine("Somewhere in Balkans");
                if (season == "summer")
                {
                    expenses = budget * 0.40;
                    Console.WriteLine($"Camp - {expenses:F2}");
                }
                else if (season == "winter")
                {
                    expenses = budget * 0.80;
                    Console.WriteLine($"Hotel - {expenses:F2}");
                }
            }
            else
            {
                Console.WriteLine("Somewhere in Europe");
                expenses = budget * 0.90;
                Console.WriteLine($"Hotel - {expenses:F2}");
            }
        }
    }
}
