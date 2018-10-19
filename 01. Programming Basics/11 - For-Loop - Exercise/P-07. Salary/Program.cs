using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P_07.Salary
{
    class Program
    {
        static void Main(string[] args)
        {
            int tabs = int.Parse(Console.ReadLine());
            double salary = double.Parse(Console.ReadLine());
            for (int i = 0; i < tabs; i++)
            {
                string website = Console.ReadLine();
                switch (website)
                {
                    case "Facebook":
                        salary -= 150.00;
                        break;
                    case "Instagram":
                        salary -= 100.00;
                        break;
                    case "Reddit":
                        salary -= 50.00;
                        break;
                    default:
                        break;
                }
                if (salary <= 0.00)
                {
                    break;
                }
            }
            if (salary <= 0.00)
            {
                Console.WriteLine("You have lost your salary.");
            }
            else
            {
                Console.WriteLine(salary);
            }
        }
    }
}
