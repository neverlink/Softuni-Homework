using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P_03.Football_Souvenirs
{
    class Program
    {
        static void Main(string[] args)
        {
            string teamName = Console.ReadLine();
            string souvenirType = Console.ReadLine();
            int souvenirCount = int.Parse(Console.ReadLine());
            double souvenirPrice = 0;
            bool invalidCountry = false;
            bool invalidStock = false;

            switch (teamName)
            {
                case "Argentina":
                    switch (souvenirType)
                    {
                        case "flags":
                            souvenirPrice = 3.25;
                            break;
                        case "caps":
                            souvenirPrice = 7.20;
                            break;
                        case "posters":
                            souvenirPrice = 5.10;
                            break;
                        case "stickers":
                            souvenirPrice = 1.25;
                            break;
                        default:
                            invalidStock = true;
                            break;
                    }
                    break;
                case "Brazil":
                    switch (souvenirType)
                    {
                        case "flags":
                            souvenirPrice = 4.20;
                            break;
                        case "caps":
                            souvenirPrice = 8.50;
                            break;
                        case "posters":
                            souvenirPrice = 5.35;
                            break;
                        case "stickers":
                            souvenirPrice = 1.20;
                            break;
                        default:
                            invalidStock = true;
                            break;
                    }
                    break;
                case "Croatia":
                    switch (souvenirType)
                    {
                        case "flags":
                            souvenirPrice = 2.75;
                            break;
                        case "caps":
                            souvenirPrice = 6.90;
                            break;
                        case "posters":
                            souvenirPrice = 4.95;
                            break;
                        case "stickers":
                            souvenirPrice = 1.10;
                            break;
                        default:
                            invalidStock = true;
                            break;
                    }
                    break;
                case "Denmark":
                    switch (souvenirType)
                    {
                        case "flags":
                            souvenirPrice = 3.10;
                            break;
                        case "caps":
                            souvenirPrice = 6.50;
                            break;
                        case "posters":
                            souvenirPrice = 4.80;
                            break;
                        case "stickers":
                            souvenirPrice = 0.90;
                            break;
                        default:
                            invalidStock = true;
                            break;
                    }
                    break;
                default:
                    invalidCountry = true;
                    break;
            }
            double total = souvenirPrice * souvenirCount;
            if (invalidCountry)
            {
                Console.WriteLine("Invalid country!");
            }
            else if (invalidStock)
            {
                Console.WriteLine("Invalid stock!");
            }
            else
            {
                Console.WriteLine($"Pepi bought {souvenirCount} {souvenirType} of {teamName} for {total:F2} lv.") ;
            }
        }
    }
}
