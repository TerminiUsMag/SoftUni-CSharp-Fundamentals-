using System;
using System.Collections.Generic;
using System.Linq;

namespace _07._Student_Academy
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<double>> courses = new Dictionary<string, List<double>>();

            Dictionary<string, double> students = new Dictionary<string, double>();

            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string name = Console.ReadLine();
                if (!courses.ContainsKey(name))
                {
                    courses[name] = new List<double>();
                }
                double grade = double.Parse(Console.ReadLine());
                courses[name].Add(grade);
            }

            foreach (var item in courses)
            {
                double avgGrade = 0;
                for (int x = 0; x < item.Value.Count; x++)
                {
                    avgGrade += item.Value[x];
                }
                avgGrade /= item.Value.Count;
                if (avgGrade >= 4.5)
                {
                    students.Add(item.Key, avgGrade);
                }
                if (avgGrade < 4.5)
                {
                    courses.Remove(item.Key);
                }
            }
            foreach (var student in students)
            {
                Console.WriteLine($"{student.Key} -> {student.Value:f2}");
            }
        }
    }
}
