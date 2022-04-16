using System;

namespace P_07._Water_Overflow
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int tankVolume = 0;

            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                int volumeToAdd = int.Parse(Console.ReadLine());
                if (tankVolume + volumeToAdd > 255)
                {
                    Console.WriteLine("Insufficient capacity!");
                    continue;
                }
                tankVolume += volumeToAdd;
            }
            Console.WriteLine(tankVolume);
        }
    }
}
