using System;
using System.Text;
using System.Text.RegularExpressions;

namespace P_02._Encrypting_Password
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int passwordCount = int.Parse(Console.ReadLine());
            for (int i = 0; i < passwordCount; i++)
            {
                string password = Console.ReadLine();
                string pattern = @"(.+)[>](?<digits>[\d]{3})\|(?<lowercase>[a-z]{3})\|(?<uppercase>[A-Z]{3})\|(?<symbols>[^\<\>]+)[<]\1";
                Match match = Regex.Match(password, pattern);

                if (match.Success)
                {
                    StringBuilder sb = new StringBuilder();
                    sb.Append(match.Groups["digits"]);
                    sb.Append(match.Groups["lowercase"]);
                    sb.Append(match.Groups["uppercase"]);
                    sb.Append(match.Groups["symbols"]);
                    Console.WriteLine($"Password: {sb}");
                }
                else
                {
                    Console.WriteLine("Try another password!");
                }
            }
        }
    }
}
