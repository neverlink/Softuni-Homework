using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P_02.Number_Pyramid
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            int counter = 0;

            for (int columns = 1; columns <= number; columns++)
            {
                for (int rows = 1; rows <= columns; rows++)
                {
                    counter++;
                    Console.Write(counter + " ");
                    if (counter == number) return;
                }
                Console.WriteLine();
            }
        }
    }
}
