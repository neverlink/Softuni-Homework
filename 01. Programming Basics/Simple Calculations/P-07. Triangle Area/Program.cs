using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P_07.Triangle_Area
{
    class Program
    {
        static void Main(string[] args)
        {
            double sideA = double.Parse(Console.ReadLine());
            double height = double.Parse(Console.ReadLine());
            double area = sideA * height / 2;

            Console.WriteLine(Math.Round(area, 2));
        }
    }
}
