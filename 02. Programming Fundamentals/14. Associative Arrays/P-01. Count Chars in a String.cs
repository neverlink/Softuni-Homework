using System;
using System.Collections.Generic;

namespace P_01._Count_Chars_in_a_String
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string inputStr = Console.ReadLine();
            
            var uniqueChars = new Dictionary<char, int>();

            foreach (char c in inputStr)
            {
                if (c == ' ')
                {
                    continue;
                }
                else if (uniqueChars.ContainsKey(c))
                {
                    uniqueChars[c] = uniqueChars[c] + 1;
                }
                else
                {
                    uniqueChars.Add(c, 1);
                }
            }

            foreach (var item in uniqueChars)
            {
                Console.WriteLine($"{item.Key} -> {item.Value}");
            }
        }
    }
}
