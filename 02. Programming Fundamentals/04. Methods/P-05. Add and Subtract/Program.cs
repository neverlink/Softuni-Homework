using System;

namespace P_05._Add_and_Subtract
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = new int[3];
            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = int.Parse(Console.ReadLine());
            }

            int firstSum = SumFirstPair(numbers[0], numbers[1]);
            int result = SubtractLastNumber(firstSum, numbers[2]);

            Console.WriteLine(result);
        }
        static int SumFirstPair (int firstNumber, int secondNumber)
        {
            return firstNumber + secondNumber;
        }
        static int SubtractLastNumber(int firstSum, int lastNumber)
        {
            return firstSum - lastNumber;
        }
    }
}
