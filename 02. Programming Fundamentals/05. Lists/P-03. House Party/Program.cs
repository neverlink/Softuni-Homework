using System;
using System.Collections.Generic;

namespace P_03._House_Party
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int commandCount = int.Parse(Console.ReadLine());

            List<string> guestList = new List<string>();

            for (int i = 0; i < commandCount; i++)
            {
                string input = Console.ReadLine();
                string guestName = input.Split()[0];

                if (input.Contains("is going"))
                {
                    if (guestList.Contains(guestName))
                         Console.WriteLine($"{guestName} is already in the list!"); 
                    else
                        guestList.Add(guestName);
                }
                else
                {
                    if (guestList.Contains(guestName))
                        guestList.Remove(guestName);
                    else
                        Console.WriteLine($"{guestName} is not in the list!");
                }
            }
            Console.WriteLine(string.Join('\n', guestList));
        }
    }
}
