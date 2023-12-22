using System;

namespace P_03._Elevator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int peopleCount = int.Parse(Console.ReadLine());
            int elevatorCapacity = int.Parse(Console.ReadLine());

            int courses = peopleCount / elevatorCapacity;
            if (peopleCount % elevatorCapacity != 0)
            {
                courses++;
            }
            Console.WriteLine(courses);
        }
    }
}
