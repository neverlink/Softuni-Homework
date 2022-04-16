using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P_07.On_Time_for_the_Exam
{
    class Program
    {
        static void Main(string[] args)
        {
            int examHour = int.Parse(Console.ReadLine());
            int examMinutes = int.Parse(Console.ReadLine());
            int arrivalHour = int.Parse(Console.ReadLine());
            int arrivalMinutes = int.Parse(Console.ReadLine());

            int difference = (examHour * 60 + examMinutes) - (arrivalHour * 60 + arrivalMinutes);
            int differenceHour = Math.Abs(difference / 60);
            int differenceMinutes = Math.Abs(difference % 60);

            if (difference == 0)
            {
                Console.WriteLine("On time");
            }
            else if (difference > 0 && difference <= 30)
            {
                Console.WriteLine("On time");
                Console.WriteLine($"{difference} minutes before the start");
            }
            else if (difference > 30)
            {
                Console.WriteLine("Early");
                if (difference >= 60)
                {
                    Console.WriteLine($"{differenceHour}:{differenceMinutes:D2} hours before the start");
                }
                else
                {
                    Console.WriteLine($"{difference} minutes before the start");
                }
            }
            else if (difference < 0)
            {
                Console.WriteLine("Late");
                if (difference <= -60)
                {
                    Console.WriteLine($"{differenceHour}:{differenceMinutes:D2} hours after the start");
                }
                else
                {
                    Console.WriteLine($"{Math.Abs(difference)} minutes after the start");
                }
            }
        }
    }
}
