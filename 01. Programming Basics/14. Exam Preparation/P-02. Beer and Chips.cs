using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P_02.Beer_and_Chips
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            double money = double.Parse(Console.ReadLine());
            int bottlesOfBeer = int.Parse(Console.ReadLine());
            int bagsOfChips = int.Parse(Console.ReadLine());

            double totalBeerPrice = bottlesOfBeer * 1.20;
            double bagOfChipsPrice = (totalBeerPrice * 0.45);
            double totalChipsPrice = Math.Ceiling(bagOfChipsPrice * bagsOfChips);
            double total = totalChipsPrice + totalBeerPrice;

            if (money >= total)
            {
                Console.WriteLine($"{name} bought a snack and has {money - total:F2} leva left.");
            }
            else
            {
                Console.WriteLine($"{name} needs {total - money:F2} more leva!");
            }
        }
    }
}
