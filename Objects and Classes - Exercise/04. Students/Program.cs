using System;
using System.Collections.Generic;
using System.Linq;

namespace _04._Students
{
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
        public override string ToString()
        {
            string result = $"{this.FirstName} {this.LastName}: {this.Grade:f2}";
            return result;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            List<Student> students = new List<Student>();

            for (int i = 0; i < n; i++)
            {
                string[] command = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);

                Student student = new Student(command[0], command[1], double.Parse(command[2]));
                students.Add(student);
            }
            List<Student> sortedList = students.OrderByDescending(x => x.Grade).ToList();
            foreach (var student in sortedList)
            {
                Console.WriteLine(student.ToString());
            }
        }
    }
}
