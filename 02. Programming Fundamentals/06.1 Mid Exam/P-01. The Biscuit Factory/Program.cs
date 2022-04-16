using System;

namespace P_01._The_Biscuit_Factory
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int dailyBiscuitsPerWorker = int.Parse(Console.ReadLine());
            int workerCount = int.Parse(Console.ReadLine());
            int biscuitGoal = int.Parse(Console.ReadLine());

            double offDaysProduction = 10 * Math.Floor(dailyBiscuitsPerWorker * workerCount * 0.75);
            double biscuitsProduced = 20 * dailyBiscuitsPerWorker * workerCount + offDaysProduction;
            double percentageDiff = Math.Abs((biscuitsProduced - biscuitGoal) / biscuitGoal * 100);

            Console.WriteLine($"You have produced {biscuitsProduced} biscuits for the past month.");

            if (biscuitsProduced > biscuitGoal)
            {
                Console.WriteLine($"You produce {percentageDiff:F2} percent more biscuits.");
            }
            else
            {
                Console.WriteLine($"You produce {percentageDiff:F2} percent less biscuits.");
            }
        }
    }
}
