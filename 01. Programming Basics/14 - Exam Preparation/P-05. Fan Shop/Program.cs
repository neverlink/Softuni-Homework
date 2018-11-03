using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P_05.Fan_Shop
{
    class Program
    {
        static void Main(string[] args)
        {
            int budget = int.Parse(Console.ReadLine());
            int count = int.Parse(Console.ReadLine());
            int total = 0;
            for (int i = 0; i < count; i++)
            {
                string item = Console.ReadLine();
                switch (item)
                {
                    case "hoodie":
                        total += 30;
                        break;
                    case "keychain":
                        total += 4;
                        break;
                    case "T-shirt":
                        total += 20;
                        break;
                    case "flag":
                        total += 15;
                        break;
                    case "sticker":
                        total += 1;
                        break;
                    default:
                        break;
                }
            }
            if (budget >= total)
            {
                Console.WriteLine($"You bought {count} items and left with {budget - total} lv.");
            }
            else
            {
                Console.WriteLine($"Not enough money, you need {total - budget} more lv.");
            }
        }
    }
}
