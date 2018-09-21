using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P_04.Tailoring_Workshop
{
    class Program
    {
        static void Main(string[] args)
        {
            int squareTables = int.Parse(Console.ReadLine());
            double squareTablesHeight = double.Parse(Console.ReadLine());
            double squareTablesWidth = double.Parse(Console.ReadLine());

            double totalArea = 5 * (squareTablesHeight + 2 * 0.30) + (squareTablesWidth + 2 * 0.30);
            double squarestotalArea = 5 * (squareTablesHeight / 2) + (squareTablesWidth / 2);

            double resultInUSD = totalArea * 7 + squarestotalArea * 9;
            double resultInBGN = resultInUSD * 1.85;

            Console.WriteLine($"{resultInUSD} USD");
            Console.WriteLine($"{resultInBGN} USD");
        }
    }
}
