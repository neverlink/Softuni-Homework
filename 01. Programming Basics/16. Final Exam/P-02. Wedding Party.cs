using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P_02.Wedding_Party
{
    class Program
    {
        static void Main(string[] args)
        {
            int guestsCount = int.Parse(Console.ReadLine());
            double budget = double.Parse(Console.ReadLine());

            double total = guestsCount * 20;

            if (budget >= total)
            {
                double moneyLeft = budget - total;
                double fireworksMoney = moneyLeft * 0.4;
                double moneyDonation = moneyLeft - fireworksMoney;
                Console.WriteLine($"Yes! {Math.Round(fireworksMoney)} lv are for fireworks and {Math.Round(moneyDonation)} lv are for donation.");
            }
            else
            {
                Console.WriteLine($"They won't have enough money to pay the covert. They will need {Math.Round(total - budget)} lv more.");
            }
        }
    }
}
