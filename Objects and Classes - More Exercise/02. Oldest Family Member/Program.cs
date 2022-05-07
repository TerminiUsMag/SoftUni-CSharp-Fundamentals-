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
        public Family(List<Person> people)
        {
            this.People = people;
        }
        public List<Person> People { get; set; }
        public void AddMember(Person member)
        {
            People.Add(member);
        }
        //public Person GetOldestMember()
        //{
        //    int maxAge = 0;
        //    Person maxMember = null;
        //    foreach (var member in People)
        //    {
        //        if (member.Age > maxAge)
        //        {
        //            maxAge = member.Age;
        //            maxMember = member;
        //        }
        //    }
        //    return maxMember;
        //}
        public Person GetOldestMember()

        {

            var oldestPerson = this.People.OrderByDescending(x => x.Age).FirstOrDefault();

            return oldestPerson;

        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            var family = new Family(new List<Person>());

            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);

                string name = input[0].Trim();
                int age = int.Parse(input[1].Trim());

                var newPerson = new Person(name, age);

                family.AddMember(newPerson);
            }

            Person oldestMemberInFamily = family.GetOldestMember();
            Console.WriteLine($"{oldestMemberInFamily.Name} {oldestMemberInFamily.Age}");
        }
    }
}
