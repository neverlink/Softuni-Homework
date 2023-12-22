using System;
using System.Collections.Generic;
using System.Linq;

namespace P_07._Student_Academy
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var students = new Dictionary<string, double>();
            int studentCount = int.Parse(Console.ReadLine());

            for (int i = 0; i < studentCount; i++)
            {
                string studentName = Console.ReadLine();
                double studentGrade = double.Parse(Console.ReadLine());

                if (!students.ContainsKey(studentName))
                {
                    students.Add(studentName, studentGrade);
                }
                else
                {
                    students[studentName] = (students[studentName] + studentGrade) / 2;
                }
            }

            foreach (var student in students
                .Where(s => s.Value >= 4.50))
            {
                Console.WriteLine($"{student.Key} -> {student.Value:F2}");
            }
        }
    }
}
