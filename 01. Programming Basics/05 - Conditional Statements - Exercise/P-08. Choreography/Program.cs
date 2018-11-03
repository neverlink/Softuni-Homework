using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P_08.Choreography
{
    class Program
    {
        static void Main(string[] args)
        {
            double stepsCount = int.Parse(Console.ReadLine());
            int dancersCount = int.Parse(Console.ReadLine());
            int days = int.Parse(Console.ReadLine());

            double stepsPerDay = Math.Ceiling(stepsCount / days / stepsCount * 100);
            double stepsPerDancer = stepsPerDay / dancersCount;

            if (stepsPerDay > 13)
            {
                Console.WriteLine($"No, They will not succeed in that goal! Required {stepsPerDancer:F2}% steps to be learned per day.");
            }
            else
            {
                Console.WriteLine($"Yes, they will succeed in that goal! {stepsPerDancer:F2}%.");
            }
        }
    }
}
