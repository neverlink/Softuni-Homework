using System;
using System.Collections.Generic;

namespace P_05._SoftUni_Parking
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var users = new Dictionary<string, string>();

            int commandCount = int.Parse(Console.ReadLine());
            for (int i = 0; i < commandCount; i++)
            {
                string[] actionParams = Console.ReadLine().Split(' ',
                    StringSplitOptions.RemoveEmptyEntries);

                string command = actionParams[0];
                string username = actionParams[1];

                if (command == "register")
                {
                    if (users.ContainsKey(username))
                    {
                        Console.WriteLine($"ERROR: already registered with plate number {users[username]}");
                    }
                    else
                    {
                        string licensePlateId = actionParams[2];
                        users.Add(username, licensePlateId);
                        Console.WriteLine($"{username} registered {licensePlateId} successfully");
                    }
                }
                else
                {
                    if (users.ContainsKey(username))
                    {
                        users.Remove(username);
                        Console.WriteLine($"{username} unregistered successfully");
                    }
                    else
                    {
                        Console.WriteLine($"ERROR: user {username} not found");
                    }
                }
            }

            foreach (var user in users)
            {
                Console.WriteLine($"{user.Key} => {user.Value}");
            }
        }
    }
}
