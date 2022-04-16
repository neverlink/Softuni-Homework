using System;
using System.Linq;

namespace P_06._Equal_Sum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] inputArr = Console.ReadLine().Split().Select(int.Parse).ToArray();

            for (int i = 0; i < inputArr.Length; i++)
            {
                int leftSum = 0;
                if (i > 0)
                {
                    for (int rightIndex = 0; rightIndex < i; rightIndex++)
                    {
                        leftSum += inputArr[rightIndex];
                    }
                }
                int rightSum = 0;
                if (i < inputArr.Length)
                {
                    for (int leftIndex = i + 1; leftIndex < inputArr.Length; leftIndex++)
                    {
                        rightSum += inputArr[leftIndex];
                    }
                }
                if (leftSum == rightSum)
                {
                    Console.WriteLine(i);
                    return;
                }
            }
            Console.WriteLine("no");
        }
    }
}
