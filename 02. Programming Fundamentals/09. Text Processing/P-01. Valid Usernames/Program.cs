using System;
using System.Linq;

namespace P_01._Valid_Usernames
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] usernames = Console.ReadLine().Split(", ",
                StringSplitOptions.RemoveEmptyEntries);
           
            foreach (string username in usernames)
            {
                bool isValid = true;

                if (username.Length < 3 || username.Length > 15)
                {
                    continue;
                }

                foreach (char c in username)
                {
                    if (!char.IsLetterOrDigit(c) && c != '-' && c != '_')
                    {
                        isValid = false;
                        break;
                    }
                }

                if (isValid)
                {
                    Console.WriteLine(username);
                }
            }
        }
    }
}
