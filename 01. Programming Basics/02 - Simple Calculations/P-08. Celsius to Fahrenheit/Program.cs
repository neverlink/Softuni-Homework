using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P_08.Celsius_to_Fahrenheit
{
    class Program
    {
        static void Main(string[] args)
        {
            double tempInCelsius = double.Parse(Console.ReadLine());
            double tempInFarenheit = tempInCelsius * 1.8 + 32;

            Console.WriteLine(Math.Round(tempInFarenheit, 2));
        }
    }
}
