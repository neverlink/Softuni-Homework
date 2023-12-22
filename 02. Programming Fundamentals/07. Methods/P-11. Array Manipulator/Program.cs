using System;
using System.Linq;

namespace P_11._Array_Manipulator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] inputArr = Console.ReadLine().Split().Select(int.Parse).ToArray();

            string command = Console.ReadLine();
            while (command != "end")
            {
                if (command.Contains("exchange"))
                {
                    int index = int.Parse(command.Split(' ')[1]);
                    inputArr = Exchange(inputArr, index);
                }
                else if (command.Contains("max") || command.Contains("min"))
                {
                    string[] parameters = command.Split(' ');
                    Compare(inputArr, parameters[0], parameters[1]);
                }
                else if (command.Contains("first") || command.Contains("last"))
                {
                    string[] parameters = command.Split(' ');
                    PrintOddEvenCount(inputArr, parameters[0], int.Parse(parameters[1]), parameters[2]);
                }
                command = Console.ReadLine();
            }
            Console.WriteLine($"[{string.Join(", ", inputArr)}]");
        }

        static int[] Exchange(int[] arr, int index)
        {
            if (index < 0 || index > arr.Length - 1)
            {
                Console.WriteLine("Invalid index");
                return arr;
            }

            int[] newArr = new int[arr.Length];
            int newArrIndex = 0;

            for (int i = index + 1; i < arr.Length; i++)
                newArr[newArrIndex++] = arr[i];

            for (int i = 0; i <= index; i++)
                newArr[newArrIndex++] = arr[i];

            return newArr;
        }

        static void Compare(int[] arr, string maxOrMin, string oddOrEven)
        {
            if (maxOrMin == "max")
            {
                int maxOddNumber = int.MinValue;
                int maxEvenNumber = int.MinValue;

                int maxOddIndex = int.MinValue;
                int maxEvenIndex = int.MinValue;

                for (int i = 0; i < arr.Length; i++)
                {
                    if (arr[i] % 2 != 0)
                    {
                        if (arr[i] >= maxOddNumber)
                        {
                            maxOddNumber = arr[i];
                            maxOddIndex = i;
                        }
                    }
                    else
                    {
                        if (arr[i] >= maxEvenNumber)
                        {
                            maxEvenNumber = arr[i];
                            maxEvenIndex = i;
                        }
                    }
                }
                if (maxOddIndex == int.MinValue && maxEvenIndex == int.MinValue)
                {
                    Console.WriteLine("No matches");
                    return;
                }
                if (oddOrEven == "odd")
                    Console.WriteLine(maxOddIndex);
                else
                    Console.WriteLine(maxEvenIndex);
            }
            else
            {
                int minOddNumber = int.MaxValue;
                int minEvenNumber = int.MaxValue;

                int minOddIndex = int.MaxValue;
                int minEvenIndex = int.MaxValue;

                for (int i = 0; i < arr.Length; i++)
                {
                    if (arr[i] % 2 != 0)
                    {

                        if (arr[i] <= minOddNumber)
                        {
                            minOddNumber = arr[i];
                            minOddIndex = i;
                        }
                    }
                    else
                    {
                        if (arr[i] <= minEvenNumber)
                        {
                            minEvenNumber = arr[i];
                            minEvenIndex = i;
                        }
                    }
                }
                if ((minOddIndex == int.MaxValue && oddOrEven == "odd") || (minEvenIndex == int.MaxValue && oddOrEven == "even"))
                {
                    Console.WriteLine("No matches");
                    return;
                }
                if (oddOrEven == "odd")
                    Console.WriteLine(minOddIndex);
                else
                    Console.WriteLine(minEvenIndex);
            }
        }

        static void PrintOddEvenCount(int[] arr, string firstOrLast, int count, string oddOrEven)
        {
            if (count > arr.Length)
            {
                Console.WriteLine("Invalid count");
                return;
            }

            int oddNumsIndex = 0;
            int[] oddNums = new int[arr.Length];

            int evenNumsIndex = 0;
            int[] evenNums = new int[arr.Length];

            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] % 2 != 0)
                {
                    oddNums[oddNumsIndex++] = arr[i];
                }
                else
                {
                    evenNums[evenNumsIndex++] = arr[i];
                }
            }

            int resultCount;
            if (oddOrEven == "odd")
            {
                if (oddNumsIndex < count)
                    resultCount = oddNumsIndex;
                else
                    resultCount = count;
            }
            else
            {
                if (evenNumsIndex < count)
                    resultCount = evenNumsIndex;
                else
                    resultCount = count;
            }
            int[] result = new int[resultCount];
            int resultIndex = 0;

            if (firstOrLast == "first")
            {
                for (int i = 0; i < result.Length; i++)
                {
                    if (oddOrEven == "odd")
                        result[i] = oddNums[i];
                    else
                        result[i] = evenNums[i];
                }
            }
            else
            {
                if (oddOrEven == "odd")
                {
                    for (int i = 0; i < result.Length; i++)
                        result[resultIndex++] = oddNums[i];
                }
                else
                {
                    for (int i = 0; i < result.Length; i++)
                        result[resultIndex++] = evenNums[i];
                }
            }
            Console.WriteLine($"[{string.Join(", ", result)}]");
        }
    }
}
