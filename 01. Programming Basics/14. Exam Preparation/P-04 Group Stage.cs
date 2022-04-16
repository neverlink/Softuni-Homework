using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P_04_Group_Stage
{
    class Program
    {
        static void Main(string[] args)
        {
            string teamName = Console.ReadLine();
            int matchesPlayed = int.Parse(Console.ReadLine());
            int teamGoals = 0;
            int enemyGoals = 0;
            int points = 0;

            for (int i = 0; i < matchesPlayed; i++)
            {
                int currentTeamGoals = int.Parse(Console.ReadLine());
                teamGoals += currentTeamGoals;
                int currentEnemyGoals = int.Parse(Console.ReadLine());
                enemyGoals += currentEnemyGoals;
                if (currentTeamGoals > currentEnemyGoals)
                {
                    points += 3;
                }
                else if (currentTeamGoals == currentEnemyGoals)
                {
                    points += 1;
                }
            }
            if (teamGoals >= enemyGoals)
            {
                Console.WriteLine($"{teamName} has finished the group phase with {points} points.");
                Console.WriteLine($"Goal difference: {teamGoals - enemyGoals}.");
            }
            else
            {
                Console.WriteLine($"{teamName} has been eliminated from the group phase.");
                Console.WriteLine($"Goal difference: {teamGoals - enemyGoals}.");
            }
        }
    }
}
