using System;

namespace P_08._Letters_Change_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] groups = Console.ReadLine().Split(' ',
                StringSplitOptions.RemoveEmptyEntries);

            double sum = 0.00;

            foreach (string group in groups)
            {
                double number = double.Parse(group.Substring(1, group.Length - 2));

                char firstChar = group[0];
                if (char.IsUpper(firstChar))
                {
                    sum += number / GetLetterPos(firstChar);
                }
                else
                {
                    sum += number * GetLetterPos(firstChar);
                }

                char lastChar = group[group.Length - 1];
                if (char.IsUpper(lastChar))
                {
                    sum -= GetLetterPos(lastChar);
                }
                else
                {
                    sum += GetLetterPos(lastChar);
                }
            }
            Console.WriteLine($"{sum:F2}");
        }

        static int GetLetterPos(char letter)
        {
            if (char.IsUpper(letter))
                return letter - 'A' + 1;
            else
                return letter - 'a' + 1;
        }
    }
}