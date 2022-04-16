using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P_08.Area_of_Figures
{
    class Program
    {
        static void Main(string[] args)
        {
            string shape = Console.ReadLine().ToLower();
            if (shape == "square")
            {
                double sideA = double.Parse(Console.ReadLine());
                double area = (sideA * sideA);
                Console.WriteLine(area);
            }
            else if (shape == "rectangle")
            {
                double sideA = double.Parse(Console.ReadLine());
                double sideB = double.Parse(Console.ReadLine());
                double area = (sideA * sideB);
                Console.WriteLine(area);
            }
            else if (shape == "circle")
            {
                double radius = double.Parse(Console.ReadLine());
                double area = Math.PI * (radius * radius);
                Console.WriteLine(area);
            }
            else if (shape == "triangle")
            {
                double sideA = double.Parse(Console.ReadLine());
                double height = double.Parse(Console.ReadLine());
                double area = (sideA * height) / 2;
                Console.WriteLine(area);
            }
        }
    }
}
