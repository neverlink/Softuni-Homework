using System;

namespace P_02._Space_Travel
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] commands = Console.ReadLine().Split("||");
            int currentFuel = int.Parse(Console.ReadLine());
            int currentAmmo = int.Parse(Console.ReadLine());

            bool missionIsSuccessful = true;

            foreach (string command in commands)
            {
                string[] cmdArgs = command.Split();
                string cmd = cmdArgs[0];
                int amount = 0;
                if (cmd != "Titan")
                {
                    amount = int.Parse(cmdArgs[1]);
                }

                if (cmd == "Travel")
                {
                    currentFuel -= amount;
                    if (currentFuel >= 0)
                    {
                        Console.WriteLine($"The spaceship travelled {cmdArgs[1]} light-years.");
                    }
                    else
                    {
                        Console.WriteLine("Mission failed.");
                        return;
                    }
                }
                else if (cmd == "Enemy")
                {
                    if (currentAmmo >= amount)
                    {
                        currentAmmo -= amount;
                        Console.WriteLine($"An enemy with {amount} armour is defeated.");
                    }
                    else
                    {
                        currentFuel -= 2 * amount;
                        if (currentFuel > 0)
                        {
                            Console.WriteLine($"An enemy with {amount} armour is outmaneuvered.");
                        }
                        else
                        {
                            Console.WriteLine("Mission failed.");
                            return;
                        }
                    }
                }
                else if (cmd == "Repair")
                {
                    currentAmmo += amount * 2;
                    currentFuel += amount;
                    Console.WriteLine($"Ammunitions added: {amount * 2}.");
                    Console.WriteLine($"Fuel added: {amount}.");
                }
                else if (cmd == "Titan")
                {
                    Console.WriteLine("You have reached Titan, all passengers are safe.");
                }
            }
        }
    }
}
