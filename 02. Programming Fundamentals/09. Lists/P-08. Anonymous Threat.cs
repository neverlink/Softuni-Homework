using System;
using System.Linq;
using System.Collections.Generic;

namespace P_08._Anonymous_Threat
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> dataList = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .ToList();

            string[] cmdParams = Console.ReadLine()
                .Split();

            while (cmdParams[0] != "3:1")
            {
                int firstParam = int.Parse(cmdParams[1]);
                int secondParam = int.Parse(cmdParams[2]);

                if (cmdParams[0] == "merge")
                {
                    Merge(dataList, startIndex: firstParam, endIndex: secondParam);
                }
                else if (cmdParams[0] == "divide")
                {
                    Divide(dataList, itemIndex: firstParam, partCount: secondParam);
                }

                cmdParams = Console.ReadLine().Split();
            }
            Console.WriteLine(string.Join(' ', dataList));
        }

        static void Merge(List<string> input, int startIndex, int endIndex)
        {
            startIndex = startIndex > 0 && startIndex < input.Count ? startIndex : 0;
            endIndex = endIndex < input.Count && endIndex >= 0 ? endIndex : input.Count - 1;

            for (int i = startIndex + 1; i <= endIndex; i++)
            {
                input[startIndex] += input[i];
            }
            input.RemoveRange(startIndex + 1, endIndex - startIndex);
        }

        static void Divide(List<string> input, int itemIndex, int partCount)
        {
            string item = input[itemIndex];

            int evenPartLength = item.Length / partCount;

            bool hasExtraPart = item.Length % partCount != 0;
            int evenPartCount = hasExtraPart ? partCount - 1 : partCount;

            List<string> splitItems = new List<string>();

            for (int i = 0; i < evenPartCount; i++)
            {
                string excerpt = item.Substring(evenPartLength * i, evenPartLength);
                splitItems.Add(excerpt);
            }

            if (hasExtraPart)
            {
                string extraItem = item.Substring(evenPartLength * evenPartCount);
                splitItems.Add(extraItem);
            }

            input.RemoveAt(itemIndex);
            input.InsertRange(itemIndex, splitItems);
        }
    }
}