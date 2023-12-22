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

            for (char sector = 'A'; sector <= lastSector; sector++)
            {
                for (int row = 1; row <= rowsPerSector; row++)
                {
                    if (row % 2 == 0)
                    {
                        for (char seat = 'a'; seat < 'a' + seatsPerEvenSector; seat++)
                        {
                            Console.WriteLine($"{sector}{row}{seat}");
                            count++;
                        }
                    }
                    else
                    {
                        for (char seat = 'a'; seat < 'a' + seatsPerOddSector; seat++)
                        {
                            Console.WriteLine($"{sector}{row}{seat}");
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
