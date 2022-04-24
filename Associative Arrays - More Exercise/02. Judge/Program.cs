using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;

namespace _02._Judge
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var mainDict = new Dictionary<string, Dictionary<string, int>>();
            var statDict = new Dictionary<string, int>();

            string command;

            while ((command = Console.ReadLine()) != "no more time")
            {
                string[] commandWords = command.Split("->", StringSplitOptions.RemoveEmptyEntries);

                string username = commandWords[0].Trim();
                string contest = commandWords[1].Trim();
                int points = int.Parse(commandWords[2].Trim());

                if (mainDict.ContainsKey(contest))
                {
                    if (mainDict[contest].ContainsKey(username))
                    {
                        if (mainDict[contest][username] < points)
                        {
                            mainDict[contest][username] = points;
                        }
                        else
                        {
                            continue;
                        }
                    }
                    else
                    {
                        mainDict[contest].Add(username, points);

                    }
                }
                else
                {

                    var currUser = new Dictionary<string, int>();
                    currUser[username] = points;
                    mainDict.Add(contest, currUser);

                }
            }

            foreach (var contestName in mainDict)
            {
                foreach (var user in contestName.Value)
                {
                    if (statDict.ContainsKey(user.Key))
                    {
                        statDict[user.Key] += user.Value;
                    }
                    else
                    {
                        statDict.Add(user.Key, user.Value);
                    }
                }
            }
            var orderedStatDict = statDict.OrderByDescending(x => x.Value).ThenBy(x => x.Key).ToDictionary(x => x.Key, x => x.Value);

            foreach (var contestName in mainDict)
            {
                Console.WriteLine($"{contestName.Key}: {contestName.Value.Count} participants");

                var orderedUsers = contestName.Value.OrderByDescending(x => x.Value).ThenBy(x => x.Key).ToDictionary(x => x.Key, x => x.Value);
                int i = 1;
                foreach (var user in orderedUsers)
                {
                    Console.WriteLine($"{i}. {user.Key} <::> {user.Value}");
                    i++;
                }
            }

            Console.WriteLine("Individual standings:");
            int x = 1;
            foreach (var contestant in orderedStatDict)
            {
                Console.WriteLine($"{x}. {contestant.Key} -> {contestant.Value} ");
                x++;
            }

        }
    }
}
