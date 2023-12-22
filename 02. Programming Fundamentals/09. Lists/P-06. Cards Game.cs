using System;
using System.Collections.Generic;
using System.Linq;

namespace P_06._Cards_Game
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> firstDeck = Console.ReadLine().Split().Select(int.Parse).ToList();
            List<int> secondDeck = Console.ReadLine().Split().Select(int.Parse).ToList();

            int losingDeckCount = Math.Min(firstDeck.Count, secondDeck.Count);

            while (losingDeckCount > 0)
            {
                int firstCard = firstDeck[0];
                int secondCard = secondDeck[0];

                if (firstCard > secondCard)
                {
                    firstDeck.Add(firstCard);
                    firstDeck.Add(secondCard);

                    firstDeck.RemoveAt(0);
                    secondDeck.RemoveAt(0);
                }
                else if (secondCard > firstCard)
                {
                    secondDeck.Add(secondCard);
                    secondDeck.Add(firstCard);

                    firstDeck.RemoveAt(0);
                    secondDeck.RemoveAt(0);
                }
                else
                {
                    firstDeck.RemoveAt(0);
                    secondDeck.RemoveAt(0);
                }
                losingDeckCount = Math.Min(firstDeck.Count, secondDeck.Count);
            }

            if (firstDeck.Count > secondDeck.Count)
            {
                int score = 0;
                for (int i = 0; i < firstDeck.Count; i++)
                {
                    score += firstDeck[i];
                }
                Console.WriteLine($"First player wins! Sum: {score}");
            }
            else
            {
                int score = 0;
                for (int i = 0; i < secondDeck.Count; i++)
                {
                    score += secondDeck[i];
                }
                Console.WriteLine($"Second player wins! Sum: {score}");
            }
        }
    }
}
