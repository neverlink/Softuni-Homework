using System;
using System.Collections.Generic;
using System.Linq;

namespace P_07._Append_Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] initialArr = Console.ReadLine().Split('|', StringSplitOptions.RemoveEmptyEntries);

            List<string> list = new List<string>();

            for (int i = initialArr.Length - 1; i >= 0; i--)
            {
                list.AddRange(initialArr[i].Split(' ', StringSplitOptions.RemoveEmptyEntries));
            }

            Console.WriteLine(string.Join(' ', list));
        }
    }
}
