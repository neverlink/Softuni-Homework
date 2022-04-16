using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P_03.Exam_Preparation
{
    class Program
    {
        static void Main(string[] args)
        {
            int toleratedGrades = int.Parse(Console.ReadLine());
            int badGradesCount = 0;
            int problemCount = 0;
            double gradeSum = 0;
            string lastProblemName = string.Empty;

            while (true)
            {
                string problemName = Console.ReadLine();
                if (problemName == "Enough")
                {
                    break;
                }
                else if (badGradesCount == toleratedGrades)
                {
                    break;
                }
                double problemGrade = double.Parse(Console.ReadLine());
                gradeSum += problemGrade;
                if (problemGrade <= 4)
                {
                    badGradesCount++;
                }
                lastProblemName = problemName;
                problemCount++;
            }
            if (badGradesCount == toleratedGrades)
            {
                Console.WriteLine($"You need a break, {badGradesCount} poor grades.");
            }
            else
            {
                Console.WriteLine($"Average score: {gradeSum / problemCount:F2}");
                Console.WriteLine($"Number of problems: {problemCount}");
                Console.WriteLine($"Last problem: {lastProblemName}");
            }
        }
    }
}
