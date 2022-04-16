using System;

namespace P_10._Top_Number
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numberLimit = int.Parse(Console.ReadLine());
            for (int i = 1; i <= numberLimit; i++)
            {
                if (IsTopNumber(i))
                {
                    Console.WriteLine(i);
                }
            }
        }
        
        static bool IsTopNumber(int number)
        {
            int digitSum = 0;
            bool hasOddDigit = false;
            while (number > 0)
            {
                int currDigit = number % 10;

                if (currDigit % 2 != 0)
                {
                    hasOddDigit = true;
                }

                digitSum += currDigit;
                number /= 10;
            }

            if (digitSum % 8 == 0 && hasOddDigit)
            {
                return true;
            }
            return false;
        }
    }
}
