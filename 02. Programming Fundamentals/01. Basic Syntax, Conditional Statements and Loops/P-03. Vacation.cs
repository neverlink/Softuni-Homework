using System;

namespace P_03._Vacation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int peopleCount = int.Parse(Console.ReadLine());
            string groupType = Console.ReadLine();
            string dayOfWeek = Console.ReadLine();

            double price = 0.00;

            switch (dayOfWeek)
            {
                case "Friday":
                    switch (groupType)
                    {
                        case "Students":
                            price = 8.45;
                            break;
                        case "Business":
                            price = 10.90;
                            break;
                        default:
                            price = 15.00;
                            break;
                    }
                    break;
                case "Saturday":
                    switch (groupType)
                    {
                        case "Students":
                            price = 9.80;
                            break;
                        case "Business":
                            price = 15.60;
                            break;
                        default:
                            price = 20.00;
                            break;
                    }
                    break;
                case "Sunday":
                    switch (groupType)
                    {
                        case "Students":
                            price = 10.46;
                            break;
                        case "Business":
                            price = 16.00;
                            break;
                        default:
                            price = 22.50;
                            break;
                    }
                    break;
                default:
                    break;
            }

            if (groupType == "Students" && peopleCount >= 30)
            {
                price *= 0.85; // 15% discount
            }
            else if (groupType == "Business" && peopleCount >= 100)
            {
                peopleCount -= 10; // 10 people stay for free
            }
            else if (groupType == "Regular" && peopleCount >= 10 && peopleCount <= 20)
            {
                price *= 0.95; // 5% discount
            }

            double totalPrice = price * peopleCount;
            Console.WriteLine($"Total price: {totalPrice:F2}"); 
        }
    }
}
