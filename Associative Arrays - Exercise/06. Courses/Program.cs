using System;
using System.Linq;
using System.Collections.Generic;

namespace _06._Courses
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<string>> dictionary = new Dictionary<string, List<string>>();

            string command = Console.ReadLine();

            while (command != "end")
            {
                string[] commandToken = command.Split(" : ", StringSplitOptions.RemoveEmptyEntries);

                if (!dictionary.ContainsKey(commandToken[0]))
                {
                    dictionary[commandToken[0]] = new List<string>();
                }
                dictionary[commandToken[0]].Add(commandToken[1]);

                command = Console.ReadLine();
            }
            foreach (var item in dictionary)
            {
                Console.WriteLine($"{item.Key}: {item.Value.Count}");
                foreach (var student in item.Value)
                {
                    Console.WriteLine($"-- {student}");
                }
            }
        }
    }
}
