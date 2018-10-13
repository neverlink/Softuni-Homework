using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P_07.Water_dispenser
{
    class Program
    {
        static void Main(string[] args)
        {
            int cupAvailableCapacity = int.Parse(Console.ReadLine());
            int tapCount = 0;

            while (cupAvailableCapacity > 0)
            {
                string input = Console.ReadLine();
                switch (input)
                {
                    case "Easy":
                        cupAvailableCapacity -= 50;
                        break;
                    case "Medium":
                        cupAvailableCapacity -= 100;
                        break;
                    case "Hard":
                        cupAvailableCapacity -= 200;
                        break;
                    default:
                        break;
                }
                tapCount++;
                if (cupAvailableCapacity < 0)
                {
                    Console.WriteLine($"{Math.Abs(cupAvailableCapacity)}ml has been spilled.");
                    break;
                }
                else if (cupAvailableCapacity == 0)
                {
                    Console.WriteLine($"The dispenser has been tapped {tapCount} times.");
                    break;
                }
            }
        }
    }
}
