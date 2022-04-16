using System;

namespace P_08._Beer_Kegs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string largestKegName = string.Empty;
            double largestKegVolume = 0.0;

            int kegCount = int.Parse(Console.ReadLine());
            for (int i = 0; i < kegCount; i++)
            {
                string name = Console.ReadLine();
                double radius = double.Parse(Console.ReadLine());
                int height = int.Parse(Console.ReadLine());

                double volume = Math.PI * Math.Pow(radius, 2)  * height;
                if (volume > largestKegVolume)
                {
                    largestKegName = name;
                    largestKegVolume = volume;
                }
            }
            Console.WriteLine(largestKegName);
        }
    }
}
