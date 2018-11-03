using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P_08.Cookie_factory
{
    class Program
    {
        static void Main(string[] args)
        {
            int batchCount = int.Parse(Console.ReadLine());
            bool containsFlour = false;
            bool containsEggs = false;
            bool containsSugar = false;
            string input = string.Empty;


            for (int i = 1; i <= batchCount;)
            {
                while (input != "Bake!")
                {
                    input = Console.ReadLine();
                    switch (input)
                    {
                        case "flour":
                            containsFlour = true;
                            break;
                        case "eggs":
                            containsEggs = true;
                            break;
                        case "sugar":
                            containsSugar = true;
                            break;
                        case "Bake!":
                            break;
                    }
                }
                if (containsFlour == false || containsEggs == false || containsSugar == false)
                {
                    Console.WriteLine("The batter should contain flour, eggs and sugar!");
                    input = string.Empty;
                }
                else
                {
                    Console.WriteLine($"Baking batch number {i}...");
                    containsFlour = false;
                    containsEggs = false;
                    containsSugar = false;
                    input = string.Empty;
                    i++;
                }
            }
        }
    }
}
