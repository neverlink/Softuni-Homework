using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P_01.Sum_Seconds
{
    class Program
    {
        static void Main(string[] args)
        {
            int timeSum = 0;

            for (int i = 0; i < 3; i++)
            {
                timeSum += int.Parse(Console.ReadLine());
            }

            int minutes = timeSum / 60;
            int seconds = timeSum % 60;
            Console.WriteLine($"{minutes}:{seconds:D2}");
        }
    }
}