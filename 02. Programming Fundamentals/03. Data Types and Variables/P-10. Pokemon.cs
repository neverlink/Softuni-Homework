using System;

namespace P_10._Pokemon
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int startingPokePower = int.Parse(Console.ReadLine());
            int distance = int.Parse(Console.ReadLine());
            int exhaustionFactor = int.Parse(Console.ReadLine());
            
            int pokePower = startingPokePower;
            int pokeCount = 0;

            while (pokePower >= distance)
            {
                pokePower -= distance;
                pokeCount++;
                if (pokePower == startingPokePower / 2 && exhaustionFactor != 0)
                {
                    pokePower /= exhaustionFactor;
                }
            }

            Console.WriteLine(pokePower);
            Console.WriteLine(pokeCount);
        }
    }
}
