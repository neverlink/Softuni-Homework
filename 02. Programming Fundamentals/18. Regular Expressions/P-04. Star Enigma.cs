using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace P_04._Star_Enigma
{
    internal class Program
    {
        private static int r;

        static void Main(string[] args)
        {
            List<string> attackedPlanets = new List<string>();
            List<string> destroyedPlanets = new List<string>();

            int messageCount = int.Parse(Console.ReadLine());
            for (int i = 0; i < messageCount; i++)
            {
                string messageToDecrypt = Console.ReadLine();
                int posToShift = Regex.Matches(messageToDecrypt,
                    @"(?i)[star]").Count;

                StringBuilder sb = new StringBuilder();
                foreach (char c in messageToDecrypt)
                {
                    sb.Append((char)(c - posToShift));
                }
                string messageDecrypted = sb.ToString();

                var match = Regex.Match(messageDecrypted,
                    @"@(?<planet>[a-zA-Z]+):(?<population>\d+)!(?<attackType>[AD])!->(?<soldiers>\d+)");

                int soldiers = int.Parse(match.Groups["soldiers"].Value);
                int population = int.Parse(match.Groups["population"].Value);

                if (soldiers > population)
                {
                    destroyedPlanets.Add(match.Groups["planet"].Value);
                }
                else
                {
                    attackedPlanets.Add(match.Groups["planet"].Value);
                }
            }

            attackedPlanets.Sort();
            Console.WriteLine($"Attacked planets: {attackedPlanets.Count}");
            foreach (string planet in attackedPlanets)
            {
                Console.WriteLine($"-> {planet}");
            }
            
            destroyedPlanets.Sort();
            Console.WriteLine($"Destroyed planets: {attackedPlanets.Count}");
            foreach (string planet in destroyedPlanets)
            {
                Console.WriteLine($"-> {planet}");
            }
        }
    }
}