using System;
using System.Collections.Generic;

namespace P_02._A_Miner_Task
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var materials = new Dictionary<string, int>();

            string input = Console.ReadLine();
            while (input != "stop")
            {
                int quantity = int.Parse(Console.ReadLine());

                if (materials.ContainsKey(input))
                {
                    materials[input] += quantity;
                }
                else
                {
                    materials.Add(input, quantity);
                }

                input = Console.ReadLine();
            }

            foreach (var material in materials)
            {
                Console.WriteLine($"{material.Key} -> {material.Value}");
            }
        }
    }
}
