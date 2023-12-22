using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P_04.Moving
{
    class Program
    {
        static void Main(string[] args)
        {
            double apartWidth = double.Parse(Console.ReadLine());
            double apartLength = double.Parse(Console.ReadLine());
            double apartHeight = double.Parse(Console.ReadLine());

            double apartCapacity = apartWidth * apartLength * apartHeight;


            string input = Console.ReadLine();
            while (input != "Done" && apartCapacity > 0)
            {

                apartCapacity -= int.Parse(input);
                input = Console.ReadLine();
            }
            if (apartCapacity > 0)
            {
                Console.WriteLine($"{apartCapacity} Cubic meters left.");
            }
            else
            {
                Console.WriteLine($"No more free space! You need {Math.Abs(apartCapacity)} Cubic meters more.");
            }
        }
    }
}
