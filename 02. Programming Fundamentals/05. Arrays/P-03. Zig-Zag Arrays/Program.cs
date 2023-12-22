using System;
using System.Linq;

namespace P_03._Zig_Zag_Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int[] firstArr = new int[n];
            int[] secondArr = new int[n];

            for (int i = 0; i < n; i++)
            {
                int[] nums = Console.ReadLine().Split().Select(int.Parse).ToArray();
                if (i % 2 == 0)
                {
                    firstArr[i] = nums[0];
                    secondArr[i] = nums[1];
                }
                else
                {
                    firstArr[i] = nums[1];
                    secondArr[i] = nums[0];
                }
            }

            Console.WriteLine(string.Join(' ', firstArr));
            Console.WriteLine(string.Join(' ', secondArr));
        }
    }
}
