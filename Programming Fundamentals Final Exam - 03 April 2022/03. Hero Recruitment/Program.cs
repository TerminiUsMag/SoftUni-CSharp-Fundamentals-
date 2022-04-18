using System;
using System.Collections.Generic;
using System.Linq;

namespace _03._Hero_Recruitment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<string>> heroesDict = new Dictionary<string, List<string>>();

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
                    case "Enroll":
                        string enrollmentHeroName = commandTokens[1];
                        if (!heroesDict.ContainsKey(enrollmentHeroName))
                        {
                            var newSpellBook = new List<string>();
                            heroesDict.Add(enrollmentHeroName, newSpellBook);
                        }
                        else
                        {
                            Console.WriteLine($"{enrollmentHeroName} is already enrolled.");
                        }
                        break;
                    case "Learn":
                        string learnSpellHeroName = commandTokens[1];
                        string learnSpellName = commandTokens[2];

                        if (heroesDict.ContainsKey(learnSpellHeroName))
                        {
                            if (heroesDict[learnSpellHeroName].Contains(learnSpellName))
                            {
                                Console.WriteLine($"{learnSpellHeroName} has already learnt {learnSpellName}.");
                            }
                            else
                            {
                                heroesDict[learnSpellHeroName].Add(learnSpellName);
                            }
                        }
                        else
                        {
                            Console.WriteLine($"{learnSpellHeroName} doesn't exist.");
                        }
                        break;
                    case "Unlearn":
                        string unlearnSpellHeroName = commandTokens[1];
                        string unlearnSpellName = commandTokens[2];

                        if (heroesDict.ContainsKey(unlearnSpellHeroName))
                        {
                            if (heroesDict[unlearnSpellHeroName].Contains(unlearnSpellName))
                            {
                                heroesDict[unlearnSpellHeroName].Remove(unlearnSpellName);
                            }
                            else
                            {
                                Console.WriteLine($"{unlearnSpellHeroName} doesn't know {unlearnSpellName}.");
                            }
                        }
                        else
                        {
                            Console.WriteLine($"{unlearnSpellHeroName} doesn't exist.");
                        }
                        break;
                }
            }
            Console.WriteLine("Heroes:");
            foreach (var hero in heroesDict)
            {
                Console.WriteLine($"== {hero.Key}: {string.Join(", ", hero.Value)}");
            }
        }
    }
}
