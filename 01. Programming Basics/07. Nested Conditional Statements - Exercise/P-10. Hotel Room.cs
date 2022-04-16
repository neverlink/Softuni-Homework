using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P_10.Hotel_Room
{
    class Program
    {
        static void Main(string[] args)
        {
            string month = Console.ReadLine().ToLower();
            int nights = int.Parse(Console.ReadLine());

            double studioCost = 0;
            double apartmentCost = 0;


            if (month == "may" || month == "october")
            {
                studioCost = 50 * nights;
                apartmentCost =  65 * nights;

                if (nights > 7 && nights < 14)
                {
                    studioCost *= 0.95;
                }
                else if (nights > 14)
                {
                    studioCost *= 0.70;
                    apartmentCost *= 0.90;
                }
            }
            else if (month == "june" || month == "september")
            {
                studioCost = 75.20 * nights;
                apartmentCost = 68.70 * nights;

                if (nights > 14)
                {
                    studioCost *= 0.80;
                    apartmentCost *= 0.90;
                }
            }
            else if (month == "july" || month == "august")
            {
                studioCost = 76 * nights;
                apartmentCost = 77 * nights;

                if (nights > 14)
                {
                    apartmentCost *= 0.90;
                }
            }
            Console.WriteLine($"Apartment: {apartmentCost:F2} lv.");
            Console.WriteLine($"Studio: {studioCost:F2} lv.");
        }
    }
}
