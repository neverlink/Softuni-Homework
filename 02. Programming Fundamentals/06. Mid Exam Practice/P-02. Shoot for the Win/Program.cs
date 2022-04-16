using System;
using System.Collections.Generic;
using System.Linq;

namespace P_02._Shoot_for_the_Win
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] targets = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int targetsShot = 0;

            string input = Console.ReadLine();
            while (input != "End")
            {
                int targetIndex = int.Parse(input);
                if (targetIndex >= 0 && targetIndex <= targets.Length - 1)
                {
                    targetsShot++;
                    int targetValue = targets[targetIndex];
                    targets[targetIndex] = -1;

                    for (int i = 0; i < targets.Length; i++)
                    {
                        if (targets[i] == -1)
                        {
                            continue;
                        }
                        else if (targets[i] > targetValue)
                        {
                            targets[i] -= targetValue;
                        }
                        else if (targets[i] <= targetValue)
                        {
                            targets[i] += targetValue;
                        }
                    }
                }
                input = Console.ReadLine();
            }
            Console.WriteLine($"Shot targets: {targetsShot} -> {string.Join(' ', targets)}");
        }
    }
}
