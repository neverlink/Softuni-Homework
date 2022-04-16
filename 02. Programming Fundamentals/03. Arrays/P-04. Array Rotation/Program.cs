using System;
using System.Linq;

namespace P_04._Array_Rotation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] inputArr = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int rotations = int.Parse(Console.ReadLine());

            for (int i = 0; i < rotations; i++)
            {
                int temp = inputArr[0];
                for (int j = 0; j < inputArr.Length - 1; j++)
                {
                    inputArr[j] = inputArr[j + 1];
                }
                inputArr[inputArr.Length - 1] = temp;
            }

            Console.WriteLine(String.Join(' ', inputArr));
        }
    }
}
