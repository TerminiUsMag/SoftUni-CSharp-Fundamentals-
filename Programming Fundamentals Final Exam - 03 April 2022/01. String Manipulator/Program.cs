using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;

namespace _01._String_Manipulator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            //StringBuilder sb = new StringBuilder();
            //sb.Append(input);

            string command;

            while ((command = Console.ReadLine()) != "End")
            {
                string[] commandTokens = command
                    .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                    .Select(x => x.Trim())
                    .ToArray();

                string currCommand = commandTokens[0];

                switch (currCommand)
                {
                    case "Translate":
                        string oldChar = commandTokens[1];
                        string newChar = commandTokens[2];

                        //sb.Replace(oldChar, newChar);
                        input = input.Replace(oldChar, newChar);
                        Console.WriteLine(input);
                        break;
                    case "Includes":
                        string subStringToFind = commandTokens[1];

                        if (input.Contains(subStringToFind))
                        {
                            Console.WriteLine("True");
                        }
                        else
                        {
                            Console.WriteLine("False");
                        }
                        break;
                    case "Start":
                        string subStringToStartWith = commandTokens[1];

                        if (input.StartsWith(subStringToStartWith))
                        {
                            Console.WriteLine("True");
                        }
                        else
                        {
                            Console.WriteLine("False");
                        }
                        break;
                    case "Lowercase":
                        input = input.ToLower();
                        Console.WriteLine(input);
                        break;
                    case "FindIndex":
                        char charToFindIndexOf = char.Parse(commandTokens[1]);
                        Console.WriteLine(input.LastIndexOf(charToFindIndexOf));
                        break;
                    case "Remove":
                        int startIndexToRemove = int.Parse(commandTokens[1]);
                        int countToRemove = int.Parse(commandTokens[2]);

                        input = input.Remove(startIndexToRemove, countToRemove);
                        Console.WriteLine(input);
                        break;
                }

                //if(currCommand == "Translate")
                //{

                //}
                //else if(currCommand =="Includes")

            }
        }
    }
}
