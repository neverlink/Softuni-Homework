using System;
using System.Linq;

namespace P_01._Train
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int wagonCount = int.Parse(Console.ReadLine());
            int[] wagons = new int[wagonCount];
            int totalPassengers = 0;
            
            for (int i = 0; i < wagonCount; i++)
            {
                int passengerCount = int.Parse(Console.ReadLine());
                wagons[i] = passengerCount;
                totalPassengers += passengerCount;
            }

            Console.WriteLine(String.Join(' ', wagons));
            Console.WriteLine(totalPassengers);
        }
    }
}
