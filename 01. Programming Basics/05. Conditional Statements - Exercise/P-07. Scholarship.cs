using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P_07.Scholarship
{
    class Program
    {
        static void Main(string[] args)
        {
            double income = double.Parse(Console.ReadLine());
            double grade = double.Parse(Console.ReadLine());
            double minimumWage = double.Parse(Console.ReadLine());

            double socialScholarship = minimumWage * 0.35;
            double gradeScholarship = grade * 25;

            if (income < minimumWage)
            {
                if (grade <= 4.50)
                {
                    Console.WriteLine("You cannot get a scholarship!");
                }
                else if (grade > 4.50 && grade < 5.50)
                {
                    Console.WriteLine($"You get a Social scholarship {Math.Floor(socialScholarship)} BGN");
                }
                else
                {
                    if (gradeScholarship >= socialScholarship)
                    {
                        Console.WriteLine($"You get a scholarship for excellent results {Math.Floor(gradeScholarship)} BGN");
                    }
                    else
                    {
                        Console.WriteLine($"You get a Social scholarship {Math.Floor(socialScholarship)} BGN");
                    }
                }
            }
            else
            {
                if (grade < 5.50)
                {
                    Console.WriteLine("You cannot get a scholarship!");
                }
                else
                {
                    Console.WriteLine($"You get a scholarship for excellent results {Math.Floor(gradeScholarship)} BGN");
                }
            }
        }
    }
}