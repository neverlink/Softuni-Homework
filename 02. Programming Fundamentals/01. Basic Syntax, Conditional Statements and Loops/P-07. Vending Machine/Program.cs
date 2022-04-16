using System;

namespace P_07._Vending_Machine
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double coinBalance = 0.0;

            while (true)
            {
                string userInput = Console.ReadLine();
                if (userInput == "Start")
                {
                    break;
                }

                double coinValue = double.Parse(userInput);
                switch (coinValue)
                {
                    case 0.1:
                        coinBalance += 0.1;
                        break;
                    case 0.2:
                        coinBalance += 0.2;
                        break;
                    case 0.5:
                        coinBalance += 0.5;
                        break;
                    case 1.0:
                        coinBalance += 1.0;
                        break;
                    case 2.0:
                        coinBalance += 2.0;
                        break;
                    default:
                        Console.WriteLine($"Cannot accept {userInput}");
                        break;
                }
            }
            while (true)
            {
                string userInput = Console.ReadLine();
                if (userInput == "End")
                {
                    break;
                }

                double price;
                string productName = userInput;
                switch (productName)
                {
                    case "Nuts":
                        price = 2.0;
                        break;
                    case "Water":
                        price = 0.7;
                        break;
                    case "Crisps":
                        price = 1.5;
                        break;
                    case "Soda":
                        price = 0.8;
                        break;
                    case "Coke":
                        price = 1.0;
                        break;
                    default:
                        Console.WriteLine("Invalid product");
                        continue;
                }
                if (coinBalance - price >= 0.0)
                {
                    coinBalance -= price;
                    Console.WriteLine($"Purchased {productName.ToLower()}");
                }
                else
                {
                    Console.WriteLine("Sorry, not enough money");
                }
            }
            Console.WriteLine($"Change: {coinBalance:F2}");
        }
    }
}
