using System;
using System.Collections.Generic;
using System.Linq;


namespace _02._Oldest_Family_Member
{
    class Person
    {
        public Person(string name, int age)
        {
            this.Name = name;
            this.Age = age;
        }
        public string Name { get; set; }
        public int Age { get; set; }
    }
    class Family
    {
        public List<Person> People { get; set; }
        void AddMember(Person member)
        {
            People.Add(member);
        }
        Person GetOldestMember()
        {
            int maxAge = 0;
            Person maxMember = null;
            foreach (var member in People)
            {
                if (member.Age > maxAge)
                {
                    maxAge = member.Age;
                    maxMember = member;
                }
            }
            return maxMember;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split(' ');

                string name = input[0];
                int age = int.Parse(input[1]);

                var newPerson = new Person();
            }
        }
    }
}
