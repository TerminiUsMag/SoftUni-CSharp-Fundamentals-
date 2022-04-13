using System;
using System.Collections.Generic;


namespace _05._Students_2._0
{
    class Student
    {
        public Student(string firstName, string lastName, int age, string homeTown)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Age = age;
            this.HomeTown = homeTown;
        }
        public string HomeTown { get; set; }
        public int Age { get; set; }
        public string LastName { get; set; }
        public string FirstName { get; set; }
    }
    internal class Program
    {
        static bool StudentExistsInList(List<Student> students, string firstName, string lastName)
        {
            foreach (Student student in students)
            {
                if (student.FirstName == firstName && student.LastName == lastName)
                {
                    return true;
                }
            }
            return false;
        }
        static Student FindExistingStudent(List<Student> students, string firstName, string lastName)
        {
            foreach(Student student in students)
            {
                if(student.FirstName==firstName && student.LastName == lastName)
                {
                    return student;
                }
            }
            return null;
        }
        static void Main(string[] args)
        {
            List<Student> students = new List<Student>();
            string command = Console.ReadLine();

            while (command != "end")
            {
                string[] data = command.Split(' ', StringSplitOptions.RemoveEmptyEntries);
                string firstName = data[0];
                string lastName = data[1];
                int age = int.Parse(data[2]);
                string homeTown = data[3];
                Student student = null;
                if (StudentExistsInList(students, firstName, lastName))
                {
                    student = FindExistingStudent(students,firstName,lastName);
                    student.FirstName = firstName;
                    student.LastName = lastName;
                    student.Age = age;
                    student.HomeTown = homeTown;
                }
                else
                {
                    student = new Student(firstName, lastName, age, homeTown);
                    students.Add(student);
                }
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
