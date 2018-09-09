using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P_06.Circle_Area_and_Perimeter
{
    class Program
    {
        static void Main(string[] args)
        {
            double radius = double.Parse(Console.ReadLine());

            double circleArea = Math.PI * Math.Pow(radius, 2);
            double circlePerimeter = 2 * Math.PI * radius;

            Console.WriteLine(circleArea);
            Console.WriteLine(circlePerimeter);
        }
    }
}
