using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P_09.Moving
{
    class Program
    {
        static void Main(string[] args)
        {
            int cribWidth = int.Parse(Console.ReadLine());
            int cribLength = int.Parse(Console.ReadLine());
            int cribHeight = int.Parse(Console.ReadLine());

            int cribSpace = cribWidth * cribLength * cribHeight;
            int spaceTaken = 0;


            while (spaceTaken < cribSpace)
            {
                string input = Console.ReadLine();
                if (input == "Done")
                {
                    break;
                }
                spaceTaken += int.Parse(input);
            }
            if (spaceTaken <= cribSpace)
            {
                Console.WriteLine($"{cribSpace - spaceTaken} Cubic meters left.");
            }
            else
            {
                Console.WriteLine($"No more free space! You need {spaceTaken - cribSpace} Cubic meters more.");
            }
        }
    }
}
