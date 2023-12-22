using System;
using System.Reflection.Metadata.Ecma335;
using System.Windows.Input;

namespace P_10._Top_Number
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arrayToModify = Console.ReadLine().Split().Select(x => int.Parse(x)).ToArray();

            string nextCommand = Console.ReadLine();
            string[] commandTokens = nextCommand.Split();

            while (nextCommand != "end")
            {
                switch (commandTokens[0]) {
                    case "exchange":
                        int index = int.Parse(commandTokens[1]);
                        arrayToModify = Exchange(arrayToModify, index);
                        break;
                    default:
                        break;
                }
            }
        }

        static int[] Exchange(int[] originalArray, int splitIndex)
        {
            if (splitIndex < 0 || splitIndex >= originalArray.Length)
            {
                Console.WriteLine("Invalid index");
                return originalArray;
            }

            //int[] newArray = new int[originalArray.Length];

            for (int i = splitIndex; i < originalArray.Length; i++)
            {
                int temp = originalArray[i];
            }

            return originalArray;
        }
    }
}