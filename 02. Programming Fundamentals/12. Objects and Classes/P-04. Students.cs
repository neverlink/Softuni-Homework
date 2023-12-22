using System;
using System.Linq;
using System.Collections.Generic;

namespace P_04._Students
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var students = new List<Student>();

            int studentCount = int.Parse(Console.ReadLine());
            for (int i = 0; i < studentCount; i++)
            {
                string[] tokens = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);
                students.Add(new Student(tokens[0], tokens[1], double.Parse(tokens[2])));
            }

            students = students.OrderByDescending(x => x.Grade).ToList();
            foreach (var student in students)
            {
                Console.WriteLine($"{student.FirstName} {student.LastName}: {student.Grade:F2}");
            }
        }
    }

    class Student
    {
        public Student(string firstName, string lastName, double grade)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Grade = grade;
        }

        public string FirstName { get; set; }

        public string LastName { get; set; }
        
        public double Grade { get; set; }
    }
}
