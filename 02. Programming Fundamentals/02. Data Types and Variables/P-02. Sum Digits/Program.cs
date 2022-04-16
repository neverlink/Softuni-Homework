using System;

namespace P_02._Sum_Digits
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int digitSum = 0;
            string numberAsText = Console.ReadLine();

            for (int i = 0; i < numberAsText.Length; i++)
            {
                digitSum += numberAsText[i] - '0';
            }
            Console.WriteLine(digitSum);
        }
    }
}
