using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P_02.Graduation
{
    class Program
    {
        static void Main(string[] args)
        {
            string studentName = Console.ReadLine();
            int counter = 12;
            double gradeSum = 0;

            while (counter > 0)
            {
                double currentGrade = double.Parse(Console.ReadLine());
                if (currentGrade >= 4)
                {
                    gradeSum += currentGrade;
                    counter--;
                }
            }
            double averageGrade = gradeSum / 12;
            Console.WriteLine($"{studentName} graduated. Average grade: {averageGrade:F2}");
        }
    }
}
