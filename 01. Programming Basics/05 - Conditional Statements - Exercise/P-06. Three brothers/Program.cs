using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P_06.Three_brothers
{
    class Program
    {
        static void Main(string[] args)
        {
            double brotherOneTime = double.Parse(Console.ReadLine());
            double brotherTwoTime = double.Parse(Console.ReadLine());
            double brotherThreeTime = double.Parse(Console.ReadLine());
            double fishingTime = double.Parse(Console.ReadLine());
            double cleaningTime = 1 / (1 / brotherOneTime + 1 / brotherTwoTime + 1 / brotherThreeTime) * 1.15;

            double timeLeft = fishingTime - cleaningTime;

            Console.WriteLine($"Cleaning time: {cleaningTime:F2}");
            if (timeLeft > 0)
            {
                Console.WriteLine($"Yes, there is a surprise - time left -> {Math.Floor(timeLeft)} hours.");
            }
            else
            {
                Console.WriteLine($"No, there isn't a surprise - shortage of time -> {Math.Ceiling(Math.Abs(timeLeft))} hours.");
            }
        }
    }
}
