using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P_10.Match_Tickets
{
    class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            string category = Console.ReadLine().ToLower();
            int peopleCount = int.Parse(Console.ReadLine());

            double ticketExpenses = 0;
            double transportationExpenses = 0;
            double expenses = 0;

            if (category == "normal")
            {
                ticketExpenses = 249.99 * peopleCount;
            }
            else
            {
                ticketExpenses = 499.99 * peopleCount;
            }

            if (peopleCount >= 1 && peopleCount <= 4)
            {
                transportationExpenses = budget * 0.75;
            }
            else if (peopleCount >= 5 && peopleCount <= 9)
            {
                transportationExpenses = budget * 0.60;
            }
            else if (peopleCount >= 10 && peopleCount <= 24)
            {
                transportationExpenses = budget * 0.50;
            }
            else if (peopleCount >= 25 && peopleCount <= 49)
            {
                transportationExpenses = budget * 0.40;
            }
            else if (peopleCount >= 50)
            {
                transportationExpenses = budget * 0.25;
            }

            expenses = ticketExpenses + transportationExpenses;

            if (budget >= expenses)
            {
                Console.WriteLine($"Yes! You have {budget - expenses:F2} leva left.");
            }
            else
            {
                Console.WriteLine($"Not enough money! You need {expenses - budget:F2} leva.");
            }
        }
    }
}
