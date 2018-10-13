using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P_03.Graduation_pt._2
{
    class Program
    {
        static void Main(string[] args)
        {
            string studentName = Console.ReadLine();
            double gradeSum = 0;
            int counter = 0;
            int failCount = 0;

            while (counter < 12)
            {
                double currentGrade = double.Parse(Console.ReadLine());
                gradeSum += currentGrade;

                if (currentGrade < 4)
                {
                    failCount++;
                    if (failCount == 2)
                    {
                        Console.WriteLine($"{studentName} has been excluded at {counter} grade");
                        break;
                    }
                }
                counter++;
            }
            if (failCount < 2)
            {
                double averageGrade = gradeSum / 12;
                Console.WriteLine($"{studentName} graduated. Average grade: {averageGrade:F2}");
            }
        }
    }
}
