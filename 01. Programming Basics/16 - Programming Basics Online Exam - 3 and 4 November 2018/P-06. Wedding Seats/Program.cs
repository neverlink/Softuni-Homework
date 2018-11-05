using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P_06.Wedding_Seats
{
    class Program
    {
        static void Main(string[] args)
        {
            char lastSector = char.Parse(Console.ReadLine());
            int rowsPerSector = int.Parse(Console.ReadLine());
            int seatsPerOddSector = int.Parse(Console.ReadLine());
            int seatsPerEvenSector = seatsPerOddSector + 2;
            int count = 0;

            for (char i = 'A'; i <= lastSector; i++)
            {
                for (int j = 1; j <= rowsPerSector; j++)
                {
                    if (j % 2 == 0)
                    {
                        for (char k = 'a'; k < 'a' + seatsPerEvenSector; k++)
                        {
                            Console.WriteLine($"{i}{j}{k}");
                            count++;
                        }
                    }
                    else
                    {
                        for (char k = 'a'; k < 'a' + seatsPerOddSector; k++)
                        {
                            Console.WriteLine($"{i}{j}{k}");
                            count++;
                        }
                    }
                }
                rowsPerSector++;
            }
            Console.WriteLine(count);
        }
    }
}
