using System;

class Program
{
    static void Main()
    {
        string destination = string.Empty;
        double moneyNeeded = 0;
        string savings = string.Empty;
        double money = 0;

        while (true)
        {
            destination = Console.ReadLine();
            if (destination == "End")
            {
                break;
            }

            moneyNeeded = double.Parse(Console.ReadLine());
            //savings = 0;
            money = 0;

            while (money < moneyNeeded)
            {
                savings = Console.ReadLine();

                if (savings == "End")
                {
                    return;
                }

                money += double.Parse(savings);

                if (money >= moneyNeeded)
                {
                    Console.WriteLine($"Going to {destination}!");
                }
            }
        }
    }
}