using System;

namespace P_05._Login
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string username = Console.ReadLine();
            string password = string.Empty;

            for (int reverseIndex = username.Length - 1; reverseIndex >= 0; reverseIndex--)
            {
                password += username[reverseIndex];
            }

            for (int attemptCount = 1; attemptCount <= 4; attemptCount++)
            {
                string enteredPassword = Console.ReadLine();

                if (enteredPassword == password)
                {
                    Console.WriteLine($"User {username} logged in.");
                    break;
                }
                else
                {
                    if (attemptCount == 4)
                    {
                        Console.WriteLine($"User {username} blocked!");
                    }
                    else
                    {
                        Console.WriteLine($"Incorrect password. Try again.");
                    }
                }
            }
        }
    }
}
