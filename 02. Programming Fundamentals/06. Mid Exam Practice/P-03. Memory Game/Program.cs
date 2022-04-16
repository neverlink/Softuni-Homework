using System;
using System.Collections.Generic;
using System.Linq;

namespace P_03._Memory_Game
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> sequence = Console.ReadLine().Split().ToList();

            int attempts = 1;

            string input = Console.ReadLine();
            while (input != "end")
            {

                int[] indicies = input.Split().Select(int.Parse).ToArray();
                int firstIndex = indicies[0];
                int secondIndex = indicies[1];

                bool indiciesAreValid = firstIndex != secondIndex
                                    && firstIndex >= 0
                                    && secondIndex >= 0
                                    && firstIndex < sequence.Count
                                    && secondIndex < sequence.Count;

                if (indiciesAreValid)
                {
                    if (sequence[firstIndex] == sequence[secondIndex])
                    {
                        string element = sequence[firstIndex];
                        Console.WriteLine($"Congrats! You have found matching elements - {element}!");
                        sequence.Remove(element);
                        sequence.Remove(element);
                    }
                    else
                    {
                        Console.WriteLine("Try again!");
                    }

                    if (sequence.Count == 0)
                    {
                        Console.WriteLine($"You have won in {attempts} turns!");
                        return;
                    }
                }
                else
                {
                    sequence.Insert(sequence.Count / 2, $"-{attempts}a");
                    sequence.Insert(sequence.Count / 2, $"-{attempts}a");
                    Console.WriteLine("Invalid input! Adding additional elements to the board");
                }

                input = Console.ReadLine();
                attempts++;
            }
            Console.WriteLine("Sorry you lose :(");
            Console.WriteLine(string.Join(' ', sequence));
        }
    }
}
