using System;
using System.Text.RegularExpressions;

namespace P_01._Furniture
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string userInput = Console.ReadLine();
            double totalSpent = 0.00;

            Console.WriteLine("Bought furniture:");

            string pattern = @">{2}([a-zA-Z]+)<{2}(\d+\.?\d+)!(\d+)";
            while (userInput != "Purchase")
            {
                var match = Regex.Match(userInput, pattern);
                if (match.Success)
                {
                    Console.WriteLine(match.Groups[1]);
                    double itemPrice = double.Parse(match.Groups[2].Value);
                    double quantity = double.Parse(match.Groups[3].Value);
                    totalSpent += itemPrice * quantity;
                }
                userInput = Console.ReadLine();
            }
            Console.WriteLine($"Total money spend: {totalSpent:F2}");
        }
    }
}
