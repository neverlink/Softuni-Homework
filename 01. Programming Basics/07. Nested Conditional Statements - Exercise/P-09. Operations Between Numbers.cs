using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P_09.Operations_Between_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            double num1 = double.Parse(Console.ReadLine());
            double num2 = double.Parse(Console.ReadLine());
            char symbol = char.Parse(Console.ReadLine());

            if (symbol == '+')
            {
                double result = num1 + num2;
                if (result % 2 == 0)
                {
                    Console.WriteLine($"{num1} + {num2} = {result} - even");
                }
                else
                {
                    Console.WriteLine($"{num1} + {num2} = {result} - odd");
                }
            }
            else if (symbol == '-')
            {
                double result = num1 - num2;
                if (result % 2 == 0)
                {
                    Console.WriteLine($"{num1} - {num2} = {result} - even");
                }
                else
                {
                    Console.WriteLine($"{num1} - {num2} = {result} - odd");
                }
            }
            else if (symbol == '*')
            {
                double result = num1 * num2;
                if (result % 2 == 0)
                {
                    Console.WriteLine($"{num1} * {num2} = {result} - even");
                }
                else
                {
                    Console.WriteLine($"{num1} * {num2} = {result} - odd");
                }
            }
            else if (symbol == '/')
            {
                if (num2 == 0)
                {
                    Console.WriteLine($"Cannot divide {num1} by zero");
                }
                else
                {
                    double result = num1 / num2;
                    Console.WriteLine($"{num1} / {num2} = {result:F2}");
                }
            }
            else if (symbol == '%')
            {
                if (num2 == 0)
                {
                    Console.WriteLine($"Cannot divide {num1} by zero");
                }
                else
                {
                    double result = num1 % num2;
                    Console.WriteLine($"{num1} % {num2} = {result}");
                }
            }
        }
    }
}
