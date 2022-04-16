using System;
using System.Linq;
using System.Collections.Generic;

namespace P_02._Change_List
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> intList = Console.ReadLine().Split().Select(int.Parse).ToList();

            string command = Console.ReadLine();
            while (command != "end")
            {
                string[] arguments = command.Split();

                if (command.Contains("Delete"))
                {
                    int element = int.Parse(arguments[1]);
                    RemoveAll(element, intList);
                }
                else
                {
                    int element = int.Parse(arguments[1]);
                    int position = int.Parse(arguments[2]);
                    intList.Insert(position, element);
                }
                command = Console.ReadLine();
            }
            Console.WriteLine(string.Join(' ', intList));
        }

        static void RemoveAll(int element, List<int> intList)
        {
            for (int i = 0; i < intList.Count; i++)
            {
                if (intList[i] == element)
                {
                    intList.Remove(element);
                }
            }
        }
    }
}
