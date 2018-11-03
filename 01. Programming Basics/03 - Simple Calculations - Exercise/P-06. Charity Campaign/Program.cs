using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P_06.Charity_Campaign
{
    class Program
    {
        static void Main(string[] args)
        {
            int days = int.Parse(Console.ReadLine());
            int cooks = int.Parse(Console.ReadLine());
            int cakeCount = int.Parse(Console.ReadLine());
            int wafflesCount = int.Parse(Console.ReadLine());
            int pancakeCount = int.Parse(Console.ReadLine());

            double totalExpenses = days * (cooks * (cakeCount * 45 + wafflesCount * 5.80 + pancakeCount * 3.20));
            double ingredientsCost = totalExpenses / 8;
            double moneyRaised = totalExpenses - ingredientsCost;
            Console.WriteLine($"{moneyRaised:F2}");
        }
    }
}
