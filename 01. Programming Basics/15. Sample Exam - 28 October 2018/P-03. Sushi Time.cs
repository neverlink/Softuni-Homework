using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P_03.Sushi_Time
{
    class Program
    {
        static void Main(string[] args)
        {
            string sushiType = Console.ReadLine();
            string resturantName = Console.ReadLine();
            int portionCount = int.Parse(Console.ReadLine());
            string delivery = Console.ReadLine();
            double portionPrice = 0;
            bool invalidResturant = false;

            switch (sushiType)
            {
                case "sashimi":
                    switch (resturantName)
                    {
                        case "Sushi Zone":
                            portionPrice = 4.99;
                            break;
                        case "Sushi Time":
                            portionPrice = 5.49;
                            break;
                        case "Sushi Bar":
                            portionPrice = 5.25;
                            break;
                        case "Asian Pub":
                            portionPrice = 4.50;
                            break;
                        default:
                            invalidResturant = true;
                            break;
                    }
                    break;
                case "maki":
                    switch (resturantName)
                    {
                        case "Sushi Zone":
                            portionPrice = 5.29;
                            break;
                        case "Sushi Time":
                            portionPrice = 4.69;
                            break;
                        case "Sushi Bar":
                            portionPrice = 5.55;
                            break;
                        case "Asian Pub":
                            portionPrice = 4.80;
                            break;
                        default:
                            invalidResturant = true;
                            break;
                    }
                    break;
                case "uramaki":
                    switch (resturantName)
                    {
                        case "Sushi Zone":
                            portionPrice = 5.99;
                            break;
                        case "Sushi Time":
                            portionPrice = 4.49;
                            break;
                        case "Sushi Bar":
                            portionPrice = 6.25;
                            break;
                        case "Asian Pub":
                            portionPrice = 5.50;
                            break;
                        default:
                            invalidResturant = true;
                            break;
                    }
                    break;
                case "temaki":
                    switch (resturantName)
                    {
                        case "Sushi Zone":
                            portionPrice = 4.29;
                            break;
                        case "Sushi Time":
                            portionPrice = 5.19;
                            break;
                        case "Sushi Bar":
                            portionPrice = 4.75;
                            break;
                        case "Asian Pub":
                            portionPrice = 5.50;
                            break;
                        default:
                            invalidResturant = true;
                            break;
                    }
                    break;
                default:
                    break;
            }
            double total = portionPrice * portionCount;
            switch (delivery)
            {
                case "Y":
                    total *= 1.20;
                    break;
                case "N":
                    break;
            }
            if (invalidResturant == true)
            {
                Console.WriteLine($"{resturantName} is invalid restaurant!");
            }
            else
            {
                Console.WriteLine($"Total price: {Math.Ceiling(total)} lv.");
            }
        }
    }
}
