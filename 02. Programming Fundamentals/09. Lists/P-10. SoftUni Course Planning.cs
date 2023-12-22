using System;
using System.Linq;
using System.Collections.Generic;

namespace P_10._SoftUni_Course_Planning
{
    internal class Program
    {
        static List<string> lessons = new List<string>();
        
        static void Main(string[] args)
        {
            lessons = Console.ReadLine().Split(", ").ToList();

            string nextCommand = Console.ReadLine();
            while (nextCommand != "course start")
            {
                string[] cmdParams = nextCommand.Split(':');

                switch (cmdParams[0])
                {
                    case "Add":
                        Add(cmdParams[1]);
                        break;
                    case "Remove":
                        Remove(cmdParams[1]);
                        break;
                    case "Insert":
                        Insert(cmdParams[1], int.Parse(cmdParams[2]));
                        break;
                    case "Swap":
                        Swap(cmdParams[1], cmdParams[2]);
                        break;
                    case "Exercise":
                        AddExercise(cmdParams[1]);
                        break;
                    default:
                        break;
                }

                nextCommand = Console.ReadLine();
            }

            for (int i = 0; i < lessons.Count; i++)
            {
                Console.WriteLine($"{i + 1}.{lessons[i]}");
            }
        }

        static void Add(string lessonTitle)
        {
            if (!lessons.Contains(lessonTitle))
            {
                lessons.Add(lessonTitle);
            }
        }

        static void Remove(string lessonTitle)
        {
            if (lessons.Contains(lessonTitle))
            {
                lessons.Remove(lessonTitle);
                lessons.Remove($"{lessonTitle}-Excercise");
            }
        }

        static void Insert(string lessonTitle, int lessonIndex)
        {
            if (!lessons.Contains(lessonTitle))
            {
                lessons.Insert(lessonIndex, lessonTitle);
            }
        }

        static void Swap(string oldLessonTitle, string newLessonTitle)
        {
            int oldLessonIndex = lessons.FindIndex(x => x == oldLessonTitle);
            int newLessonIndex = lessons.FindIndex(x => x == newLessonTitle);

            if (oldLessonIndex != -1 && newLessonIndex != -1)
            {
                lessons[oldLessonIndex] = newLessonTitle;
                lessons[newLessonIndex] = oldLessonTitle;

                if (oldLessonIndex + 1 < lessons.Count)
                {
                    if (lessons[oldLessonIndex + 1] == $"{oldLessonTitle}-Exercise")
                    {
                        lessons.RemoveAt(oldLessonIndex + 1);
                        lessons.Insert(newLessonIndex + 1, $"{oldLessonTitle}-Exercise");
                    }
                }

                if (newLessonIndex + 1 < lessons.Count)
                {
                    if (lessons[newLessonIndex + 1] == $"{newLessonTitle}-Exercise")
                    {
                        lessons.RemoveAt(newLessonIndex + 1);
                        lessons.Insert(oldLessonIndex + 1, $"{newLessonTitle}-Exercise");
                    }
                }
            }
        }
        
        static void AddExercise(string lessonTitle)
        {
            int lessonIndex = lessons.FindIndex(x => x == lessonTitle);

            if (lessonIndex == -1)
            {
                lessons.Add(lessonTitle);
                lessons.Add($"{lessonTitle}-Exercise");
            }
            else if (!lessons.Contains($"{lessonTitle}-Exercise"))
            {
                lessons.Insert(lessonIndex + 1, $"{lessonTitle}-Exercise");
            }
        }
    }
}