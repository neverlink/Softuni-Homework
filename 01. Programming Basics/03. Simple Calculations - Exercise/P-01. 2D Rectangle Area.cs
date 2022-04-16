using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P_01._2D_Rectangle_Area
{
    class Program
    {
        static void Main(string[] args)
        {
            double pointX1 = double.Parse(Console.ReadLine());
            double pointY1 = double.Parse(Console.ReadLine());
            double pointX2 = double.Parse(Console.ReadLine());
            double pointY2 = double.Parse(Console.ReadLine());

            double width = Math.Abs(pointX1 - pointX2);
            double height = Math.Abs(pointY1 - pointY2);

            double area = width * height;
            double perimeter = 2 * (width + height);
            Console.WriteLine(area);
            Console.WriteLine(perimeter);
        }
    }
}
