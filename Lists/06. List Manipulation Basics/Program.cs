using System;
using System.Collections.Generic;
using System.Linq;

namespace _06._List_Manipulation_Basics
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> numbersList = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();

            string command = Console.ReadLine();

            while (command != "end")
            {
                string[] commands = command.Split();

                switch (commands[0])
                {
                    case "Add":
                        int numberToAdd = int.Parse(commands[1]);
                        numbersList.Add(numberToAdd);
                        break;
                    case "Remove":
                        int numberToRemove = int.Parse(commands[1]);
                        numbersList.Remove(numberToRemove);
                        break;
                    case "RemoveAt":
                        int indexToRemove = int.Parse(commands[1]);
                        numbersList.RemoveAt(indexToRemove);
                        break;
                    case "Insert":
                        int numberToInsert = int.Parse(commands[1]);
                        int indexToInsert = int.Parse(commands[2]);
                        numbersList.Insert(indexToInsert, numberToInsert);
                        break;
                }
                command = Console.ReadLine();
            }
            Console.WriteLine(String.Join(' ', numbersList));
        }
    }
}
