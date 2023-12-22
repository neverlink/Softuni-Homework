using System;

namespace P_06._Replace_Repeating_Chars
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string inputStr = Console.ReadLine();

            int i = 0;
            while (i < inputStr.Length - 1)
            {
                if (inputStr[i] == inputStr[i + 1])
                {
                    inputStr = inputStr.Remove(i, 1);
                }
                else
                {
                    i++;
                }
            }
            Console.WriteLine(inputStr);
        }
    }
}
