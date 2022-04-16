using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P_04.Vacation
{
    class Program
    {
        static void Main(string[] args)
        {
            double requiredMoney = double.Parse(Console.ReadLine());
            double availableMoney = double.Parse(Console.ReadLine());
            int daysCounter = 0;
            int spendCount = 0;

            while (true)
            {
                string action = Console.ReadLine();
                double amount = double.Parse(Console.ReadLine());

                if (action == "spend")
                {
                    availableMoney -= amount;
                    spendCount++;
                    daysCounter++;
                    if (availableMoney < 0)
                    {
                        availableMoney = 0;
                    }
                    if (spendCount == 5)
                    {
                        Console.WriteLine("You can't save the money.");
                        Console.WriteLine(daysCounter);
                        break;
                    }
                }
                else if (action == "save")
                {
                    availableMoney += amount;
                    spendCount = 0;
                    daysCounter++;
                    if (availableMoney >= requiredMoney)
                    {
                        Console.WriteLine($"You saved the money for {daysCounter} days.");
                        break;
                    }
                }
            }
        }
    }
}
