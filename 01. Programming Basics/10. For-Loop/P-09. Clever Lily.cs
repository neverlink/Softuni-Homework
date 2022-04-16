using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P_09.Clever_Lily
{
    class Program
    {
        static void Main(string[] args)
        {
            int age = int.Parse(Console.ReadLine());
            double dishwasherCost = double.Parse(Console.ReadLine());
            int toyPrice = int.Parse(Console.ReadLine());
            int toyCount = 0;
            int lilyMoney = 0;

            for (int i = 1; i <= age; i++)
            {
                if (i % 2 == 0)
                {
                    lilyMoney += i * 5 - 1;
                }
                else
                {
                    toyCount++;
                }
            }
            lilyMoney += toyCount * toyPrice;
            if (lilyMoney >= dishwasherCost)
            {
                Console.WriteLine($"Yes! {lilyMoney - dishwasherCost:F2}");
            }
            else
            {
                Console.WriteLine($"No! {dishwasherCost - lilyMoney:F2}");

            }
        }
    }
}
