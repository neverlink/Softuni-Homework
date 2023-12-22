using System;
using System.Linq;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace P_02._Race
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var participants = new Dictionary<string, int>();

            string[] participantNames = Console.ReadLine()
                .Split(", ", StringSplitOptions.RemoveEmptyEntries);

            foreach (string name in participantNames)
            {
                participants.Add(name, 0);
            }

            string userInput = Console.ReadLine();
            while (userInput != "end of race")
            {
                MatchCollection matchLetters = Regex.Matches(userInput, @"[a-zA-Z]+");
                string participantName = string.Join(string.Empty, matchLetters);

                if (participants.ContainsKey(participantName))
                {
                    MatchCollection matchDigits = Regex.Matches(userInput, @"[0-9]");
                    int distance = matchDigits.Sum(m => int.Parse(m.Value));
                    participants[participantName] += distance;
                }
                userInput = Console.ReadLine();
            }

            var sortedParticipants = participants.OrderByDescending(m => m.Value).Take(3).ToList();
            Console.WriteLine($"1st place: {sortedParticipants[0].Key}");
            Console.WriteLine($"2nd place: {sortedParticipants[1].Key}");
            Console.WriteLine($"3rd place: {sortedParticipants[2].Key}");
        }
    }
}