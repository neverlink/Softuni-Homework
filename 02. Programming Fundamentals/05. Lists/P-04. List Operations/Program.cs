using System;
using System.Linq;
using System.Collections.Generic;

namespace P_04._List_Operations
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();

            string input = Console.ReadLine();
            while (input != "End")
            {
                string[] arguments = input.Split();
                string command = arguments[0];

                if (command == "Add")
                {
                    numbers.Add(int.Parse(arguments[1]));
                }
                else if (command == "Insert")
                {
                    int index = int.Parse(arguments[2]);
                    if (index >= 0 && index < numbers.Count)
                        numbers.Insert(int.Parse(arguments[2]), int.Parse(arguments[1]));
                    else
                        Console.WriteLine("Invalid index");
                }
                else if (command == "Remove")
                {
                    int index = int.Parse(arguments[1]);
                    if (index >= 0 && index < numbers.Count)
                        numbers.RemoveAt(int.Parse(arguments[1]));
                    else
                        Console.WriteLine("Invalid index");
                }
                else if (command.Contains("Shift"))
                {
                    ShiftElements(numbers, arguments[1], int.Parse(arguments[2]));
                }

                input = Console.ReadLine();
            }
            Console.WriteLine(string.Join(' ', numbers));
        }

        private static void ShiftElements(List<int> intList, string direction, int count)
        {
            if (direction == "left")
            {
                for (int i = 0; i < count; i++)
                {
                    intList.Add(intList[0]);
                    intList.RemoveAt(0);
                }
            }
            else
            {
                for (int i = 0; i < count; i++)
                {
                    intList.Insert(0, intList[^1]);
                    intList.RemoveAt(intList.Count - 1);
                }
            }
        }
    }
}