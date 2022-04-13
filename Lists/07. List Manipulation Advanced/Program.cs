using System;
using System.Collections.Generic;
using System.Linq;

namespace _07._List_Manipulation_Advanced
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
            bool madeChanges = false;

            while (command != "end")
            {
                string[] commands = command.Split();

                switch (commands[0])
                {
                    case "Add":
                        int numberToAdd = int.Parse(commands[1]);
                        numbersList.Add(numberToAdd);
                        madeChanges = true;
                        break;
                    case "Remove":
                        int numberToRemove = int.Parse(commands[1]);
                        numbersList.Remove(numberToRemove);
                        madeChanges = true;
                        break;
                    case "RemoveAt":
                        int indexToRemove = int.Parse(commands[1]);
                        numbersList.RemoveAt(indexToRemove);
                        madeChanges = true;
                        break;
                    case "Insert":
                        int numberToInsert = int.Parse(commands[1]);
                        int indexToInsert = int.Parse(commands[2]);
                        numbersList.Insert(indexToInsert, numberToInsert);
                        madeChanges = true;
                        break;
                    case "Contains":
                        int numberToFind = int.Parse(commands[1]);
                        if (numbersList.Contains(numberToFind))
                        {
                            Console.WriteLine("Yes");
                        }
                        else
                        {
                            Console.WriteLine("No such number");
                        }
                        break;
                    case "PrintEven":
                        List<int> evenList = new List<int>();
                        numbersList.ForEach(delegate (int num)
                        {
                            if (num % 2 == 0) evenList.Add(num);
                        });
                        Console.WriteLine(String.Join(' ', evenList));
                        break;
                    case "PrintOdd":
                        List<int> oddList = new List<int>();
                        numbersList.ForEach(delegate (int num)
                        {
                            if (num % 2 != 0) oddList.Add(num);
                        });
                        Console.WriteLine(String.Join(' ', oddList));
                        break;
                    case "GetSum":
                        int sum = 0;
                        for (int i = 0; i < numbersList.Count; i++)
                        {
                            sum += numbersList[i];
                        }
                        Console.WriteLine(sum);
                        break;
                    case "Filter":
                        string condition = commands[1];
                        int numberToFilter = int.Parse(commands[2]);
                        List<int> filteredNumbers = new List<int>();
                        for (int j = 0; j < numbersList.Count; j++)
                        {
                            if (condition == "<")
                            {
                                if (numbersList[j] < numberToFilter)
                                {
                                    filteredNumbers.Add(numbersList[j]);
                                }
                            }
                            else if (condition == ">")
                            {
                                if (numbersList[j] > numberToFilter)
                                {
                                    filteredNumbers.Add(numbersList[j]);
                                }
                            }
                            else if (condition == ">=")
                            {
                                if (numbersList[j] >= numberToFilter)
                                {
                                    filteredNumbers.Add(numbersList[j]);
                                }
                            }
                            else if (condition == "<=")
                            {
                                if (numbersList[j] <= numberToFilter)
                                {
                                    filteredNumbers.Add(numbersList[j]);
                                }
                            }
                        }
                        Console.WriteLine(String.Join(' ', filteredNumbers));
                        break;
                }
                command = Console.ReadLine();
            }
            if (madeChanges)
            {
                Console.WriteLine(String.Join(' ', numbersList));
            }
        }
    }
}
