using System;
using System.Linq;

namespace P_08._Magic_Sum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] inputArr = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int magicSum = int.Parse(Console.ReadLine());

            for (int firstCounter = 0; firstCounter < inputArr.Length; firstCounter++)
            {
                for (int secondCounter = firstCounter + 1; secondCounter < inputArr.Length; secondCounter++)
                {
                    if (inputArr[firstCounter] + inputArr[secondCounter] == magicSum)
                    {
                        Console.WriteLine(inputArr[firstCounter] + " " + inputArr[secondCounter]);
                    }
                }
            }
        }
    }
}
