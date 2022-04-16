using System;

namespace P_08._Factorial_Division
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int firstNum = int.Parse(Console.ReadLine());
            int secondNum = int.Parse(Console.ReadLine());

            long firstFactorial = calcFactorial(firstNum);
            long secondFactorial = calcFactorial(secondNum);

            Console.WriteLine($"{firstFactorial / (double)secondFactorial:F2}");
        }

        static long calcFactorial(int num)
        {
            long factorial = 1;
            for (int i = 2; i <= num; i++)
            {
                factorial *= i;
            }
            return factorial;
        }
    }
}
