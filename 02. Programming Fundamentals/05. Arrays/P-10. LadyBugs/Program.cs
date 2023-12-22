using System;
using System.Linq;

namespace P_10._LadyBugs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] field = new int[int.Parse(Console.ReadLine())];

            int[] ladybugPositions = Console.ReadLine().Split().Select(int.Parse).ToArray();

            if (ladybugPositions.Length > field.Length)
            {
                return;
            }

            foreach (int index in ladybugPositions)
            {
                field[index] = 1;
            }

            while (true)
            {
                string nextCommand = Console.ReadLine();

                if (nextCommand == "end")
                {
                    break;
                }

                string[] cmdParams = nextCommand.Split();
                int ladybugIndex = int.Parse(cmdParams[0]);
                int directionMultiplier = cmdParams[1] == "right" ? 1 : -1;
                int flightDistance = int.Parse(cmdParams[2]);

                if (field[ladybugIndex] == 0 || ladybugIndex < 0 || ladybugIndex >= field.Length)
                {
                    continue;
                }

                //if (flightDistance == 0) // 1 test less
                //{
                //    field[ladybugIndex] = 0;
                //}
                field[ladybugIndex] = 0;

                while (true)
                {
                    int destinationIndex = ladybugIndex + (flightDistance * directionMultiplier);

                    if (destinationIndex >= 0 && destinationIndex < field.Length)
                    {
                        if (field[destinationIndex] == 0)
                        {
                            field[destinationIndex] = 1;
                            break;
                        }
                        flightDistance++;
                    }
                    else
                    {
                        break;
                    }
                }
            }
            Console.WriteLine(string.Join(' ', field));
        }
    }
}