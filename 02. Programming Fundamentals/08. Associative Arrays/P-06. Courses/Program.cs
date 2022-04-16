using System;
using System.Collections.Generic;

namespace P_06._Courses
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var courses = new Dictionary<string, List<string>>();

            string input = Console.ReadLine();
            while (input != "end")
            {
                string[] courseParams = input.Split(" : ",
                    StringSplitOptions.RemoveEmptyEntries);

                string courseName = courseParams[0];
                string studentName = courseParams[1];

                if (courses.ContainsKey(courseName))
                {
                    courses[courseName].Add(studentName);
                }
                else
                {
                    courses.Add(courseName, new List<string>() { studentName });
                }

                input = Console.ReadLine();
            }

            foreach (var course in courses)
            {
                Console.WriteLine($"{course.Key}: {course.Value.Count}");
                foreach (string studentName in course.Value)
                {
                    Console.WriteLine($"-- {studentName}");
                }
            }
        }
    }
}
