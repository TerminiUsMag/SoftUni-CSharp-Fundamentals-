using System;
using System.Collections.Generic;
using System.Linq;

namespace _08._Company_Users
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<string>> dictionary = new Dictionary<string, List<string>>();

            string command = Console.ReadLine();

            while (command != "End")
            {
                string[] commandToken = command.Split(" -> ", StringSplitOptions.RemoveEmptyEntries);

                if (!dictionary.ContainsKey(commandToken[0]))
                {
                    dictionary[commandToken[0]] = new List<string>();
                }
                if (!dictionary[commandToken[0]].Contains(commandToken[1]))
                {
                    dictionary[commandToken[0]].Add(commandToken[1]);
                }

                command = Console.ReadLine();
            }
            foreach (var item in dictionary)
            {
                Console.WriteLine($"{item.Key}");
                foreach (var id in item.Value)
                {
                    Console.WriteLine($"-- {id}");
                }
            }
        }
    }
}
