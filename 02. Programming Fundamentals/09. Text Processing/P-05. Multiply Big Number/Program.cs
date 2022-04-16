using System;
using System.Text;

namespace P_05._Multiply_Big_Number
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string multiplicand = Console.ReadLine();
            int multiplier = int.Parse(Console.ReadLine());

            StringBuilder sb = new StringBuilder();

            int temp = 0;

            for (int i = multiplicand.Length - 1; i > 0; i--)
            {
                int currDigit = (multiplicand[i] - '0') * multiplier + temp;
                if (currDigit >= 10)
                {
                    temp = currDigit / 10;
                    currDigit = currDigit % 10;
                }
                else
                {
                    temp = 0;
                }
                sb.Insert(0, currDigit);
            }
            sb.Insert(0, (multiplicand[0] - '0') * multiplier + temp);

            if (sb[0] == '0')
            {
                sb = new StringBuilder().Append('0');
            }
            Console.WriteLine(sb.ToString());
        }
    }
}