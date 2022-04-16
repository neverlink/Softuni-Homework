using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P_01.Sea_Trip
{
    class Program
    {
        static void Main(string[] args)
        {
            double foodExpensesPerDay = double.Parse(Console.ReadLine());
            double souvenirExpensesPerDay = double.Parse(Console.ReadLine());
            double hotelExpensesPerDay = double.Parse(Console.ReadLine());

            double gasExpenses = (420.00 / 100 * 7) * 1.85;
            double totalhotelExpenses = (hotelExpensesPerDay * 0.90) + (hotelExpensesPerDay * 0.85) + (hotelExpensesPerDay * 0.80);
            double total = gasExpenses + totalhotelExpenses + foodExpensesPerDay * 3 + souvenirExpensesPerDay * 3;
            Console.WriteLine($"Money needed: {total:F2}");
        }
    }
}
