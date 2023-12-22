using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P_05.Bus
{
    class Program
    {
        static void Main(string[] args)
        {
            int passengerCount = int.Parse(Console.ReadLine());
            int stopCount = int.Parse(Console.ReadLine());
            for (int currentStop = 1; currentStop <= stopCount; currentStop++)
            {
                if (currentStop % 2 != 0)
                {
                    passengerCount -= int.Parse(Console.ReadLine());
                    passengerCount += int.Parse(Console.ReadLine());
                    passengerCount += 2;
                }
                else
                {
                    passengerCount -= int.Parse(Console.ReadLine());
                    passengerCount += int.Parse(Console.ReadLine());
                    passengerCount -= 2;
                }
            }
            Console.WriteLine($"The final number of passengers is : {passengerCount}"); 
        }
    }
}
