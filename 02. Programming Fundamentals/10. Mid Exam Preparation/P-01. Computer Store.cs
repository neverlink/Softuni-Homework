using System;

namespace P_01._Computer_Store
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double totalUntaxed = 0.00;

            string input = Console.ReadLine();
            while (input != "regular" && input != "special")
            {
                double partPrice = double.Parse(input);
                if (partPrice > 0.00)
                {
                    totalUntaxed += partPrice;
                }
                else
                {
                    Console.WriteLine("Invalid price!");
                }
                input = Console.ReadLine();
            }

            if (totalUntaxed > 0.00)
            {
                Console.WriteLine("Congratulations you've just bought a new computer!");
                Console.WriteLine($"Price without taxes: {totalUntaxed:F2}$");

                double taxAmount = totalUntaxed * 0.20;

                Console.WriteLine($"Taxes: {taxAmount:F2}$");
                Console.WriteLine("-----------");
                double grandTotal = input == "special" ? (totalUntaxed + taxAmount) * 0.90 : totalUntaxed + taxAmount;
                Console.WriteLine($"Total price: {grandTotal:F2}$");
            }
            else
            {
                Console.WriteLine("Invalid order!");
            }
        }
    }
}
