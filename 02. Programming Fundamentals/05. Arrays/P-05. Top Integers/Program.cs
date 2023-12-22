using System;
using System.Linq;

namespace P_05._Top_Integers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] inputArr = Console.ReadLine().Split().Select(int.Parse).ToArray();

            for (int i = 0; i < inputArr.Length; i++)
            {
                int possibleTopNum = inputArr[i];
                bool isTopNumber = true;
                for (int j = i; j < inputArr.Length - 1; j++)
                {
                    int nextNum = inputArr[j + 1];
                    if (possibleTopNum <= nextNum)
                    {
                        isTopNumber = false;
                        break;
                    }
                }
                if (isTopNumber)
                {
                    Console.Write(possibleTopNum + " ");
                }
            }
        }
    }
}