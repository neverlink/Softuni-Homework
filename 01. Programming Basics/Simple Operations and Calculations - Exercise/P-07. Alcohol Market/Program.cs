using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P_07.Alcohol_Market
{
    class Program
    {
        static void Main(string[] args)
        {
            double whiskeyPrice = double.Parse(Console.ReadLine());
            double beerAmount = double.Parse(Console.ReadLine());
            double wineAmount = double.Parse(Console.ReadLine());
            double rakiaAmount = double.Parse(Console.ReadLine());
            double whiskeyAmount = double.Parse(Console.ReadLine());

            double rakiaPrice = whiskeyPrice / 2;
            double winePrice = rakiaPrice * 0.6;
            double beerPrice = rakiaPrice * 0.2;

            double total = (beerAmount * beerPrice) + (wineAmount * winePrice) + (rakiaAmount * rakiaPrice) + (whiskeyAmount * whiskeyPrice);
            Console.WriteLine(Math.Round(total, 2));
        }
    }
}
