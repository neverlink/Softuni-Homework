using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P_07.Trade_Comissions
{
    class Program
    {
        static void Main(string[] args)
        {
            string city = Console.ReadLine().ToLower();
            double sales = double.Parse(Console.ReadLine());
            double comission = -1;

            if (city == "sofia")
            {
                if (0 <= sales && sales <= 500)
                {
                    comission = 0.05;
                }
                else if (500 < sales && sales <= 1000)
                {
                    comission = 0.07;
                }
                else if (1000 < sales && sales <= 10000)
                {
                    comission = 0.08;
                }
                else if (sales > 10000)
                {
                    comission = 0.12;
                }
            }
            else if (city == "varna")
            {
                if (sales >= 0 && sales <= 500)
                {
                    comission = 0.045;
                }
                else if (500 < sales && sales <= 1000)
                {
                    comission = 0.075;
                }
                else if (1000 < sales && sales <= 10000)
                {
                    comission = 0.1;
                }
                else if (sales > 10000)
                {
                    comission = 0.13;
                }
            }
            else if (city == "plovdiv")
            {
                if (sales >= 0 && sales <= 500)
                {
                    comission = 0.055;
                }
                else if (500 < sales && sales <= 1000)
                {
                    comission = 0.08;
                }
                else if (1000 < sales && sales <= 10000)
                {
                    comission = 0.12;
                }
                else if (sales > 10000)
                {
                    comission = 0.145;
                }
            }
            if (comission >= 0)
            {
                Console.WriteLine($"{(sales * comission):F2}");
            }
            else
            {
                Console.WriteLine("error");
            }
        }
    }
}
