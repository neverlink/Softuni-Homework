using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P_07.Name_Wars
{
    class Program
    {
        static void Main(string[] args)
        {
            int sum = 0;
            int largestSum = 0;
            string name = string.Empty;
            string winnerName = string.Empty;
            string input = Console.ReadLine();

            while (input != "STOP")
            {
                sum = 0;
                name = input;
                for (int i = 0; i < name.Length; i++)
                {
                    sum += name[i];
                }
                if (sum >= largestSum)
                {
                    largestSum = sum;
                    winnerName = name;
                }
                input = Console.ReadLine();
            }
            Console.WriteLine($"Winner is {winnerName} - {largestSum}! ");
        }
    }
}
