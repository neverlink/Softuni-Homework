using System;

namespace P_09._Spice_Must_Flow
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int currentYield = int.Parse(Console.ReadLine());

            int daysOperated = 0;
            int spiceExtracted = 0;

            while (currentYield >= 100)
            {
                spiceExtracted += currentYield;
                spiceExtracted -= 26;
                currentYield -= 10;
                daysOperated++;
            }
            if (spiceExtracted >= 26)
                spiceExtracted -= 26;

            Console.WriteLine(daysOperated);
            Console.WriteLine(spiceExtracted);
        }
    }
}
