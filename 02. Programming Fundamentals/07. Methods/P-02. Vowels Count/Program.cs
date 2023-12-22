using System;

namespace P_02._Vowels_Count
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string word = Console.ReadLine();
            Console.WriteLine(GetVowelCount(word));
        }

        static int GetVowelCount(string word)
        {
            word = word.ToLower();
            char[] vowels = new char[] { 'a', 'e', 'i', 'o', 'u', 'y' };
            int vowelSum = 0;

            for (int wordIndex = 0; wordIndex < word.Length; wordIndex++)
            {
                for (int vowelIndex = 0; vowelIndex < vowels.Length; vowelIndex++)
                {
                    if (word[wordIndex] == vowels[vowelIndex])
                    {
                        vowelSum++;
                    }
                }
            }
            return vowelSum;
        }
    }
}
