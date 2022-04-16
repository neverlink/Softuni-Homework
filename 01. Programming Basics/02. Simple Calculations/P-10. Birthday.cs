using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P_10.Birthday
{
    class Program
    {
        static void Main(string[] args)
        {
            int length = int.Parse(Console.ReadLine());
            int width = int.Parse(Console.ReadLine());
            int height = int.Parse(Console.ReadLine());
            double accessoryPercentage = double.Parse(Console.ReadLine());

            double aquariumVolume = length * width * height; // In centimeters
            double totalWater = aquariumVolume / 1000;
            double waterNeeded = totalWater - (totalWater * accessoryPercentage / 100);

            Console.WriteLine(waterNeeded);
        }
    }
}
