using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P_01.Wedding_Time
{
    class Program
    {
        static void Main(string[] args)
        {
            double whiskeyPrice = double.Parse(Console.ReadLine());
            double shampagnePrice = whiskeyPrice * 0.50;
            double winePrice = shampagnePrice * 0.40;
            double waterPrice = shampagnePrice * 0.10;

            double waterAmount = double.Parse(Console.ReadLine());
            double wineAmount = double.Parse(Console.ReadLine());
            double shampagneAmount = double.Parse(Console.ReadLine());
            double whiskeyAmount = double.Parse(Console.ReadLine());

            double total = (waterAmount * waterPrice) + (wineAmount * winePrice) + (shampagneAmount * shampagnePrice) + (whiskeyAmount * whiskeyPrice);
            Console.WriteLine($"{total:F2}");
        }
    }
}
