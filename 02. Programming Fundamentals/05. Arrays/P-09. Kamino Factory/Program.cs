using System;
using System.Linq;

namespace P_09._Kamino_Factory
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int lengthDNA = int.Parse(Console.ReadLine());
            int[] bestDNA = new int[lengthDNA];

            int bestLengthDNA = 0;
            int bestStartDNA = 0;
            int bestSumDNA = 0;

            int bestIndexDNA = 0;
            int currIndexDNA = 0;

            string nextCommand = Console.ReadLine();
            while (nextCommand != "Clone them!")
            {
                int[] DNA = nextCommand
                    .Split('!', StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse)
                    .ToArray();

                int currLengthSeq = 0;
                int currStartSeq = 0;
                int currSumDNA = 0;

                for (int i = 0; i < DNA.Length; i++)
                {
                    currSumDNA += DNA[i];

                    if (DNA[i] == 1)
                    {
                        if (currLengthSeq == 0)
                        {
                            currStartSeq = i;
                        }
                        currLengthSeq++;
                    }

                    bool isSuperiorDNA = false;

                    if (currLengthSeq > bestLengthDNA)
                    {
                        isSuperiorDNA = true;
                    }
                    else if (currLengthSeq == bestLengthDNA)
                    {
                        if (currStartSeq < bestStartDNA)
                        {
                            isSuperiorDNA = true;
                        }
                        else
                        {
                            if (currSumDNA > bestSumDNA)
                            {
                                isSuperiorDNA = true;
                            }
                        }
                    }

                    if (isSuperiorDNA)
                    {
                        bestDNA = DNA;
                        bestLengthDNA = currLengthSeq;
                        bestStartDNA = currStartSeq;
                        bestIndexDNA = currIndexDNA;
                    }

                    if (bestIndexDNA == currIndexDNA)
                    {
                        bestSumDNA = currSumDNA;
                    }

                    if (DNA[i] == 0)
                    {
                        currStartSeq = 0;
                        currLengthSeq = 0;
                    }
                }
                currIndexDNA++;
                nextCommand = Console.ReadLine();
            }
            Console.WriteLine($"Best DNA sample {bestIndexDNA + 1} with sum: {bestSumDNA}.");
            Console.WriteLine(string.Join(' ', bestDNA));
        }
    }
}