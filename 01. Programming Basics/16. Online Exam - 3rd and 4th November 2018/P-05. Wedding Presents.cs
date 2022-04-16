using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P_05.Wedding_Presents
{
    class Program
    {
        static void Main(string[] args)
        {
            int guestCount = int.Parse(Console.ReadLine());
            int giftCount = int.Parse(Console.ReadLine());

            double moneyGifts = 0;
            double applianceGifts = 0;
            double voucherGifts = 0;
            double otherGifts = 0;
            double giftsGiven = (double)giftCount / guestCount * 100;

            for (int i = 0; i < giftCount; i++)
            {
                string input = Console.ReadLine();
                switch (input)
                {
                    case "A":
                        moneyGifts++;
                        break;
                    case "B":
                        applianceGifts++;
                        break;
                    case "V":
                        voucherGifts++;
                        break;
                    case "G":
                        otherGifts++;
                        break;
                    default:
                        break;
                }
            }
            moneyGifts = moneyGifts / giftCount * 100;
            applianceGifts = applianceGifts / giftCount * 100;
            voucherGifts = voucherGifts / giftCount * 100;
            otherGifts = otherGifts / giftCount * 100;

            Console.WriteLine($"{moneyGifts:F2}%");
            Console.WriteLine($"{applianceGifts:F2}%");
            Console.WriteLine($"{voucherGifts:F2}%");
            Console.WriteLine($"{otherGifts:F2}%");
            Console.WriteLine($"{giftsGiven:F2}%");
        }
    }
}
