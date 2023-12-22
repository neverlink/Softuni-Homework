using System;

namespace P_09._Padawan_Equipment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double moneyAvailable = double.Parse(Console.ReadLine());
            int studentCount = int.Parse(Console.ReadLine());

            double sabrePrice = double.Parse(Console.ReadLine());
            double robePrice = double.Parse(Console.ReadLine());
            double beltPrice = double.Parse(Console.ReadLine());

            double saberSum = sabrePrice * Math.Ceiling(studentCount * 1.1);// 10% student headroom
            double robeSum = robePrice * studentCount;
            double beltSum = beltPrice * (studentCount - studentCount / 6); // Every 6th belt is free
            
            double sum = saberSum + robeSum + beltSum;
          
            if (moneyAvailable - sum >= 0)
            {
                Console.WriteLine($"The money is enough - it would cost {sum:F2}lv.");
            }
            else
            {
                Console.WriteLine($"John will need {sum - moneyAvailable:F2}lv more.");
            }
        }
    }
}
