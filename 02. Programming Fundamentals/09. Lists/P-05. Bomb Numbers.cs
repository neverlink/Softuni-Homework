using System;
using System.Linq;
using System.Collections.Generic;

namespace P_05._Bomb_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();

            string[] input = Console.ReadLine().Split();
            int bombNumber = int.Parse(input[0]);
            int bombPower = int.Parse(input[1]);

            while(numbers.Contains(bombNumber))
            {
                DetonateNumbers(numbers, bombNumber, bombPower);
            }

            int sum = 0;
            for (int i = 0; i < numbers.Count; i++)
            {
                sum += numbers[i];
            }
            Console.WriteLine(sum);
        }

        static void DetonateNumbers(List<int> numbers, int bombNumber, int bombPower)
        {
            int bombIndex = numbers.IndexOf(bombNumber);
            int removedCount = 0;

            for (int i = 0; i < numbers.Count + removedCount; i++)
            {
                if (i >= bombIndex - bombPower && i <= bombIndex + bombPower)
                {
                    numbers.RemoveAt(i - removedCount);
                    removedCount++;
                }
            }
        }
    }
}
