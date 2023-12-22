using System;
using System.Linq;
using System.Collections.Generic;

namespace P_09._Pokemon_Don_t_Go
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> pokedex = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();

            int removedSum = 0;

            while (pokedex.Count > 0)
            {
                int indexToRemove = int.Parse(Console.ReadLine());
                int removedElement = 0;

                if (indexToRemove < 0)
                {
                    removedElement = pokedex.First();
                    pokedex[0] = pokedex.Last();
                }
                else if (indexToRemove > pokedex.Count - 1)
                {
                    removedElement = pokedex.Last();
                    pokedex[pokedex.Count - 1] = pokedex.First();
                }
                else
                {
                    removedElement = pokedex[indexToRemove];
                    pokedex.RemoveAt(indexToRemove);
                }

                removedSum += removedElement;

                for (int i = 0; i < pokedex.Count; i++)
                {
                    if (pokedex[i] <= removedElement)
                    {
                        pokedex[i] += removedElement;
                    }
                    else
                    {
                        pokedex[i] -= removedElement;
                    }
                }
            }
            Console.WriteLine(removedSum);
        }
    }
}