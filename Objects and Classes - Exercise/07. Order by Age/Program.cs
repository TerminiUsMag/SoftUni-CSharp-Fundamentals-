using System;
using System.Collections.Generic;
using System.Linq;

namespace _07._Order_by_Age
{
    class Person
    {
        public Person(string name, string id, int age)
        {
            this.ID = id;
            this.Name = name;
            this.Age = age;
        }
        public string Name { get; set; }
        public string ID { get; set; }
        public int Age { get; set; }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            string command;

            List<Person> people = new List<Person>();

            while ((command = Console.ReadLine()) != "End")
            {
                string[] commandToken = command.Split(' ');

                string name = commandToken[0];
                string id = commandToken[1];
                int age = int.Parse(commandToken[2]);

                Person currentPerson = people.FirstOrDefault(p => p.ID == id);
                if (currentPerson != null)
                {
                    people.Remove(people.FirstOrDefault(p => p.ID == id));
                    currentPerson.Age = age;
                    currentPerson.Name = name;
                    people.Add(currentPerson);
                    continue;
                }

                Person newPerson = new Person(name, id, age);
                people.Add(newPerson);
            }
            List<Person> sortedPeople = people.OrderBy(x => x.Age).ToList();

            foreach (var person in sortedPeople)
            {
                Console.WriteLine($"{person.Name} with ID: {person.ID} is {person.Age} years old.");
            }
            Console.WriteLine();
        }
    }
}
