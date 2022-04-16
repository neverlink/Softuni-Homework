using System;
using System.Linq;

namespace P_07._Max_Sequence_of_Equal_Elements
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] inputArr = Console.ReadLine().Split().Select(int.Parse).ToArray();

            int maxSeqDigit = 0;
            int maxSeqLength = 0;
            
            for (int i = 0; i < inputArr.Length - 1; i++)
            {
                int currSeqDigit = inputArr[i];
                int currSeqLength = 1;

                for (int j = i; j < inputArr.Length - 1; j++)
                {
                    if (inputArr[j] == inputArr[j + 1])
                    {
                        currSeqLength++;
                    }
                    else
                    {
                        break;
                    }
                }
                if (currSeqLength > maxSeqLength)
                {
                    maxSeqLength = currSeqLength;
                    maxSeqDigit = currSeqDigit;
                }
            }
            for (int i = 0; i < maxSeqLength; i++)
            {
                Console.Write(maxSeqDigit + " ");
            }
        }
    }
}
