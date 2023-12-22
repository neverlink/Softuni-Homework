using System;

namespace P_07._String_Explosion
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string inputStr = Console.ReadLine();
            int bombsLeft = 0;

            for (int i = 0; i < inputStr.Length; i++)
            {
                if (inputStr[i] == '>')
                {
                    bombsLeft += inputStr[i + 1] - '0';
                    continue;
                }
                while (bombsLeft > 0 && inputStr[i] != '>')
                {
                    inputStr = inputStr.Remove(i, 1);
                    bombsLeft--;
                    i--;
                }
            }
            Console.WriteLine(inputStr);
        }
    }
}