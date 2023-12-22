using System;

namespace P_01._Integer_Operations
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int firstNumber = int.Parse(Console.ReadLine());
            int secondNumber = int.Parse(Console.ReadLine());
            int thirdNumber = int.Parse(Console.ReadLine());
            int fourthNumber = int.Parse(Console.ReadLine());

            int firstResult = firstNumber + secondNumber;
            int secondResult = firstResult / thirdNumber;
            int thirdResult = secondResult * fourthNumber;

            Console.WriteLine(thirdResult);
        }
    }
}
