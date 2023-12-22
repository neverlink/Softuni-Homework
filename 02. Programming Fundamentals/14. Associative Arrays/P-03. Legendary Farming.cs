using System;
using System.Collections.Generic;
using System.Linq;

namespace P_03._Legendary_Farming
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var materials = new Dictionary<string, int>()
            {
                { "shards", 0 },
                { "motes", 0 },
                { "fragments", 0 }
            };

            bool isLegendaryObtained = false;
            while (!isLegendaryObtained)
            {
                string[] tokens = Console.ReadLine()
                    .Split(' ', StringSplitOptions.RemoveEmptyEntries);

                for (int i = 0; i < tokens.Length; i += 2)
                {
                    int quantity = int.Parse(tokens[i]);
                    string material = tokens[i + 1].ToLower();

                    if (materials.ContainsKey(material))
                    {
                        materials[material] += quantity;
                    }
                    else
                    {
                        materials[material] = quantity;
                    }

                    if (materials[material] >= 250)
                    {
                        if (material == "shards")
                        {
                            isLegendaryObtained = true;
                            materials["shards"] -= 250;
                            Console.WriteLine("Shadowmourne obtained!");
                            break;
                        }
                        else if (material == "motes")
                        {
                            isLegendaryObtained = true;
                            materials["motes"] -= 250;
                            Console.WriteLine("Dragonwrath obtained!");
                            break;
                        }
                        else if (material == "fragments")
                        {
                            isLegendaryObtained = true;
                            materials["fragments"] -= 250;
                            Console.WriteLine("Valanyr obtained!");
                            break;
                        }
                    }
                }
            }

            foreach (var material in materials)
            {
                Console.WriteLine($"{material.Key}: {material.Value}");
            }
        }
    }
}
