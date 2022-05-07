using System;
using System.Collections.Generic;
using System.Linq;


namespace _02._Oldest_Family_Member
{
    class Person
    {
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
            Console.WriteLine("Hello World!");
        }
    }
}
