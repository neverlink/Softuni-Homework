using System;

namespace P_09._Palindrome_Integers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            while (input != "END")
            {
                Console.WriteLine(IsPalindrome(input));
                input = Console.ReadLine();
            }
        }

        static string IsPalindrome(string number)
        {
            string numberReversed = string.Empty;
            for (int i = number.Length - 1; i >= 0; i--)
            {
                numberReversed += number[i];
            }
            if (number == numberReversed)
            {
                return "true";
            }
            return "false"; // Judge requires lowercase
        }
    }
}
