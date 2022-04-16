using System;

namespace P_02._Character_Multiplier
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] stringsToSum = Console.ReadLine().Split();
            Console.WriteLine(SumStrings(stringsToSum[0], stringsToSum[1]));
        }

        static int SumStrings(string firstStr, string secondStr)
        {
            int sum = 0;

            string shorterStr = firstStr.Length <= secondStr.Length ? firstStr : secondStr;
            string longerStr = firstStr.Length > secondStr.Length ? firstStr : secondStr;

            for (int i = 0; i < shorterStr.Length; i++)
            {
                sum += longerStr[i] * shorterStr[i];
            }

            if (longerStr.Length > shorterStr.Length)
            {
                for (int i = shorterStr.Length; i < longerStr.Length; i++)
                {
                    sum += longerStr[i];
                }
            }

            return sum;
        }
    }
}
