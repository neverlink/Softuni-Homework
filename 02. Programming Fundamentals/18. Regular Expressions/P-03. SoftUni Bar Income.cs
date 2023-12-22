using System;
using System.Text.RegularExpressions;

namespace P_03._SoftUni_Bar_Income
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double totalIncome = 0.00;

            string userInput = Console.ReadLine();
            while (userInput != "end of shift")
            {
                var match = Regex.Match(userInput,
                    @"(?:[^\|\$\%\.\d]*)%([A-Z][a-z]+)%(?:[^\|\$\%\.\d]*)<(\w+)>(?:[^\|\$\%\.\d]*)\|(?:[^\|\$\%\.\d]*)(\d+)(?:[^\|\$\%\.\d]*)\|(?:[^\|\$\%\.\d]*)(\d+(?:\.\d*)?)\$");
                if (match.Success)
                {
                    string customerName = match.Groups[1].ToString();
                    string productName = match.Groups[2].ToString();
                    int protudctQty = int.Parse(match.Groups[3].ToString());
                    double productPrice = double.Parse(match.Groups[4].ToString());

                    double currentSum = productPrice * protudctQty;
                    totalIncome += currentSum;

                    Console.WriteLine($"{ customerName}: {productName} - {currentSum:F2}");
                }
                userInput = Console.ReadLine();
            }
            Console.WriteLine($"Total income: {totalIncome:F2}");
        }
    }
}