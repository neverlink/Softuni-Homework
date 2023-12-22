using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P_03.Wedding_Investment
{
    class Program
    {
        static void Main(string[] args)
        {
            string contractLength = Console.ReadLine();
            string contractType = Console.ReadLine();
            string desert = Console.ReadLine();
            int paymentMonths = int.Parse(Console.ReadLine());
            double total = 0;

            switch (contractLength)
            {
                case "one":
                    switch (contractType)
                    {
                        case "Small":
                            total += 9.98;
                            break;
                        case "Middle":
                            total += 18.99;
                            break;
                        case "Large":
                            total += 25.98;
                            break;
                        case "ExtraLarge":
                            total += 35.99;
                            break;
                        default:
                            break;
                    }
                    break;
                case "two":
                    switch (contractType)
                    {
                        case "Small":
                            total += 8.58;
                            break;
                        case "Middle":
                            total += 17.09;
                            break;
                        case "Large":
                            total += 23.59;
                            break;
                        case "ExtraLarge":
                            total += 31.79;
                            break;
                        default:
                            break;
                    }
                    break;
                default:
                    break;
            }
            switch (desert)
            {
                case "yes":
                    if (total <= 10.00)
                    {
                        total += 5.50;
                    }
                    else if (total > 10 && total <= 30.00)
                    {
                        total += 4.35;
                    }
                    else if (total > 30)
                    {
                        total += 3.85;
                    }
                    break;
                case "no":
                    break;
                default:
                    break;
            }
            if (contractLength == "two")
            {
                total *= 0.9625;
            }
            Console.WriteLine($"{total * paymentMonths:F2} lv.");
        }
    }
}
