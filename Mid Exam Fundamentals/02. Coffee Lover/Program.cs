using System;
using System.Collections.Generic;
using System.Linq;

namespace _02._Coffee_Lover
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> coffees = Console.ReadLine()
                .Split()
                .ToList();
            int n = int.Parse(Console.ReadLine());

            List<string> command = new List<string>();

            //Include = add to end of list.
            //Remove = remove first/last, number of times(if the number is greater than the number of coffees, skip the command).
            //Prefer = change the coffees on the two indexes (if there is no such indexes skip the command).
            //Reverse = reverse the order ofthe coffees.

            for (int i = 0; i < n; i++)
            {
                command = Console.ReadLine().Split().ToList();

                if (command[0] == "Include")
                {
                    coffees.Add(command[1]);
                }
                else if (command[0] == "Remove")
                {
                    if (int.Parse(command[2]) > coffees.Count) command[1] = "none";
                    if (command[1] == "first")
                    {
                        for (int k = 0; k < int.Parse(command[2]); k++)
                            coffees.RemoveAt(0);
                    }
                    if (command[1] == "last")
                    {
                        for (int k = 0; k < int.Parse(command[2]); k++)
                            coffees.RemoveAt(coffees.Count - 1);
                    }
                }
                else if (command[0] == "Prefer")
                {
                    if (int.Parse(command[1]) < coffees.Count || int.Parse(command[2]) < coffees.Count)
                    {
                        string firstIndex = coffees[int.Parse(command[1])];
                        string secondIndex = coffees[int.Parse(command[2])];

                        coffees[int.Parse(command[1])] = secondIndex;
                        coffees[int.Parse(command[2])] = firstIndex;
                    }
                }
                else if (command[0] == "Reverse")
                {
                    coffees.Reverse();
                }
            }
            Console.WriteLine("Coffees:");
            Console.WriteLine(String.Join(" ", coffees));
        }
    }
}
