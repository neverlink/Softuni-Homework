using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P_02.Cinema
{
    class Program
    {
        static void Main(string[] args)
        {
            string projection = Console.ReadLine().ToLower();
            int rows = int.Parse(Console.ReadLine());
            int columns = int.Parse(Console.ReadLine());
            double ticketPrice = 0;

            switch (projection)
            {
                case "premiere":
                    ticketPrice = 12.00;
                    break;
                case "normal":
                    ticketPrice = 7.50;
                    break;
                case "discount":
                    ticketPrice = 5.00;
                    break;
                default:
                    break;
            }
            Console.WriteLine($"{(rows * columns * ticketPrice):F2}");
        }
    }
}
