using System;
using System.Collections.Generic;

namespace _04._Students
{
    class Student
    {
        public Student(string firstName, string lastName, string age, string homeTown)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Age = int.Parse(age);
            this.HomeTown = homeTown;
        }
        public string HomeTown { get; set; }
        public int Age { get; set; }
        public string LastName { get; set; }
        public string FirstName { get; set; }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Student> students = new List<Student>();
            string command = Console.ReadLine();

            while (command != "end")
            {
                string[] data = command.Split(' ', StringSplitOptions.RemoveEmptyEntries);

                Student student = new Student(data[0], data[1], data[2], data[3]);

                students.Add(student);
                command = Console.ReadLine();
            }
            string cityName = Console.ReadLine();
            foreach (Student student in students)
            {
                if (student.HomeTown == cityName)
                {
                    Console.WriteLine($"{student.FirstName} {student.LastName} is {student.Age} years old.");
                }
            }
        }
    }
}
