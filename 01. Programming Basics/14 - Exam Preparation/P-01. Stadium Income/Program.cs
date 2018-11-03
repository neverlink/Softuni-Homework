using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P_01.Stadium_Income
{
    class Program
    {
        static void Main(string[] args)
        {
            int stadiumSectors = int.Parse(Console.ReadLine());
            int stadiumCapacity = int.Parse(Console.ReadLine());
            double ticketPrice = double.Parse(Console.ReadLine());

            double totalIncome = stadiumCapacity * ticketPrice;
            double sectorIncome = totalIncome / stadiumSectors;
            double charityMoney = (totalIncome - sectorIncome * 0.75) / 8;

            Console.WriteLine($"Total income - {totalIncome:F2} BGN");
            Console.WriteLine($"Money for charity - {charityMoney:F2} BGN");
        }
    }
}
