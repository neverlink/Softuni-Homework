using System;

namespace P_11._Orders
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int orderCount = int.Parse(Console.ReadLine());
            
            double totalPrice = 0.0;

            for (int i = 0; i < orderCount; i++)
            {
                double pricePerCapsule = double.Parse(Console.ReadLine());
                int days = int.Parse(Console.ReadLine());
                int capsuleCount = int.Parse(Console.ReadLine());

                double coffeePrice = (days * capsuleCount) * pricePerCapsule;
                Console.WriteLine($"The price for the coffee is: ${coffeePrice:F2}");
                totalPrice += coffeePrice;
            }
            Console.WriteLine($"Total: ${totalPrice:F2}");
        }
    }
}
