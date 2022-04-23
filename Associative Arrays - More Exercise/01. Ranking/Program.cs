using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _01._Ranking
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var mainDict = new Dictionary<string, string>();
            var userDict = new SortedDictionary<string, Dictionary<string, int>>();

            string command;

            while ((command = Console.ReadLine()) != "end of contests")
            {
                string[] commandTokens = command.Split(':', StringSplitOptions.RemoveEmptyEntries);

                mainDict[commandTokens[0]] = commandTokens[1];
            }

            while ((command = Console.ReadLine()) != "end of submissions")
            {
                string[] commandTokens = command.Split("=>", StringSplitOptions.RemoveEmptyEntries);

                string contest = commandTokens[0];
                string password = commandTokens[1];
                string username = commandTokens[2];
                int points = int.Parse(commandTokens[3]);

                foreach (var item in mainDict)
                {
                    if (contest == item.Key && password == item.Value)
                    {
                        if (userDict.ContainsKey(username))
                        {
                            if (userDict[username].ContainsKey(contest))
                            {
                                if (userDict[username][contest] < points)
                                {
                                    userDict[username][contest] = points;
                                }
                            }
                            else
                            {
                                userDict[username].Add(contest, points);
                            }
                        }
                        else
                        {
                            userDict.Add(username, new Dictionary<string, int> { { contest, points } });
                        }
                    }
                }
            }
            int currMax = 0;
            string currBest = string.Empty;

            foreach (var item in userDict)
            {
                int sum = 0;
                foreach (var item2 in item.Value)
                {
                    sum += item2.Value;
                }
                if (sum > currMax)
                {
                    currMax = sum;
                    currBest = item.Key;
                }
            }
            //var orderedUserDict = userDict.OrderBy(x => x.Value.Values).ToDictionary(x => x.Key, x => x.Value);


            Console.WriteLine($"Best candidate is {currBest} with total {currMax} points.");
            Console.WriteLine("Ranking: ");
            foreach (var user in userDict)
            {
                var ordered = user.Value.OrderByDescending(x => x.Value).ToDictionary(x => x.Key, x => x.Value);
                Console.WriteLine(user.Key);
                foreach (var user2 in ordered)
                {

                    Console.WriteLine($"#  {user2.Key} -> {user2.Value}");
                }
            }

        }
    }
}
