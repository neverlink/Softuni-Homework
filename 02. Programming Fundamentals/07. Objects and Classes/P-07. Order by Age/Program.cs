using System;
using System.Linq;
using System.Collections.Generic;

namespace P_07._Order_by_Age
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<User> users = new List<User>();

            string input = Console.ReadLine();
            while (input != "End")
            {
                string[] splitArgs = input.Split(' ',
                    StringSplitOptions.RemoveEmptyEntries);

                string name = splitArgs[0];
                string id = splitArgs[1];
                int age = int.Parse(splitArgs[2]);

                bool userFound = false;

                for (int i = 0; i < users.Count; i++)
                {
                    if (users[i].Id == id)
                    {
                        users[i].Name = name;
                        users[i].Age = age;

                        userFound = true;
                        break;
                    }
                }

                if (!userFound)
                {
                    users.Add(new User(name, id, age));
                }

                input = Console.ReadLine();
            }

            foreach (var user in users.OrderBy(x => x.Age))
            {
                Console.WriteLine($"{user.Name} with ID: {user.Id} is {user.Age} years old.");
            }
        }
    }

    class User
    {
        public string Name { get; set; }

        public string Id { get; set; }

        public int Age { get; set; }
        
        public User(string name, string id, int age)
        {
            this.Name = name;
            this.Id = id;
            this.Age = age;
        }
    }
}