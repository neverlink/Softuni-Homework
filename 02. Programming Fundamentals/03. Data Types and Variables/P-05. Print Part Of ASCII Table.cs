using System;

namespace P_05._Print_Part_Of_ASCII_Table
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int startIndex = int.Parse(Console.ReadLine());
            int endIndex = int.Parse(Console.ReadLine());
            string result = string.Empty;
            
            for (int i = startIndex; i <= endIndex; i++)
            {
                result += (char)i + " ";
            }
            Console.WriteLine(result);
        }
    }
}
