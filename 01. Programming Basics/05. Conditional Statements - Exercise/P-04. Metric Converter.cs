using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P_04.Metric_Converter
{
    class Program
    {
        static void Main(string[] args)
        {
            double distance = double.Parse(Console.ReadLine());
            string from = Console.ReadLine();
            string to = Console.ReadLine();

            switch (from)
            {
                case "mm":
                    distance /= 1000;
                    break;
                case "cm":
                    distance /= 100;
                    break;
                case "m":
                    break;
                case "km":
                    distance /= 0.001;
                    break;
                case "in":
                    distance /= 39.3700787;
                    break;
                case "ft":
                    distance /= 3.2808399;
                    break;
                case "yd":
                    distance /= 1.0936133;
                    break;
                case "mi":
                    distance /= 0.000621371192;
                    break;
                default:
                    break;
            }
            switch (to)
            {
                case "mm":
                    distance *= 1000;
                    break;
                case "cm":
                    distance *= 100;
                    break;
                case "m":
                    break;
                case "km":
                    distance *= 0.001;
                    break;
                case "in":
                    distance *= 39.3700787;
                    break;
                case "ft":
                    distance *= 3.2808399;
                    break;
                case "yd":
                    distance *= 1.0936133;
                    break;
                case "mi":
                    distance *= 0.000621371192;
                    break;
                default:
                    break;
            }
            Console.WriteLine($"{distance:F8}");
        }
    }
}
