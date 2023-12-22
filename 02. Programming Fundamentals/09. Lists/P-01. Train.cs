using System;
using System.Collections.Generic;
using System.Linq;

namespace P_01._Train
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> wagons = Console.ReadLine().Split().Select(int.Parse).ToList();
            int wagonCapacity = int.Parse(Console.ReadLine());

            string input = Console.ReadLine();
            while (input != "end")
            {
                if (input.Contains("Add"))
                {
                    wagons.Add(int.Parse(input[4..]));
                }
                else
                {
                    int passengerCount = int.Parse(input);
                    for (int i = 0; i < wagons.Count; i++)
                    {
                        if (passengerCount <= wagonCapacity - wagons[i])
                        {
                            wagons[i] += passengerCount;
                            break;
                        }
                    }
                }
                input = Console.ReadLine();
            }
            Console.WriteLine(string.Join(' ', wagons));
        }
    }
}
