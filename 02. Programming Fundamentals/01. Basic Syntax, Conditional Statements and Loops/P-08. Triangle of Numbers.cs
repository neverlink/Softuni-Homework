using System;

namespace P_08._Triangle_of_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());

            for (int rowindex = 1; rowindex <= number; rowindex++)
            {
                string row = string.Empty;
                for (int col = 0; col < rowindex; col++)
                {
                    row += rowindex + " ";
                }
                Console.WriteLine(row);
            }
        }
    }
}
