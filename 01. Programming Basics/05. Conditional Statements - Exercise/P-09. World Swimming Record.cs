using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P_09.World_Swimming_Record
{
    class Program
    {
        static void Main(string[] args)
        {
            double worldRecord = double.Parse(Console.ReadLine());
            double distance = double.Parse(Console.ReadLine());
            double timeForOneMeter = double.Parse(Console.ReadLine());

            double ivanchoTime = distance * timeForOneMeter + Math.Floor(distance / 15) * 12.5;

            if (ivanchoTime >= worldRecord)
            {
                Console.WriteLine($"No, he failed! He was {Math.Abs(worldRecord - ivanchoTime):F2} seconds slower.");
            }
            else
            {
                Console.WriteLine($"Yes, he succeeded! The new world record is {ivanchoTime:F2} seconds.");
            }
        }
    }
}
