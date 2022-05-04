using System;
using System.Collections.Generic;
using System.Linq;


namespace _05._Dragon_Army
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            var dragonArmy = new Dictionary<string, SortedDictionary<string, List<int>>>();
            var listOfTypes = new List<string>();
            var typesDict = new Dictionary<string, List<double>>();


            for (int i = 0; i < n; i++)
            {
                //format "{type} {name} {damage} {health} {armor}".
                //health 250, damage 45, and armor 10.Missing stat will be marked by null

                string[] command = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);

                string type = command[0];
                string name = command[1];
                int damage;
                int health;
                int armor;
                if (command[2] == "null")
                {
                    damage = 45;
                }
                else
                {
                    damage = int.Parse(command[2]);
                }
                if (command[3] == "null")
                {
                    health = 250;
                }
                else
                {
                    health = int.Parse(command[3]);
                }
                if (command[4] == "null")
                {
                    armor = 10;
                }
                else
                {
                    armor = int.Parse(command[4]);
                }

                if (dragonArmy.ContainsKey(type))
                {
                    if (dragonArmy[type].ContainsKey(name))
                    {
                        dragonArmy[type][name] = new List<int> { damage, health, armor };
                    }
                    else
                    {
                        dragonArmy[type].Add(name, new List<int> { damage, health, armor });
                    }
                }

                if (!dragonArmy.ContainsKey(type))
                {
                    var newList = new List<int>() { damage, health, armor };
                    var newDict = new SortedDictionary<string, List<int>>();
                    newDict.Add(name, newList);
                    dragonArmy.Add(type, newDict);
                }

                if (!listOfTypes.Contains(type))
                {
                    listOfTypes.Add(type);
                }

                if (!typesDict.ContainsKey(type))
                {
                    typesDict.Add(type, new List<double>() { 0, 0, 0, 0 });
                }
            }

            foreach (var dragonsType in dragonArmy)
            {
                foreach (var dragon in dragonsType.Value)
                {
                    typesDict[dragonsType.Key][0] += dragon.Value[0];
                    typesDict[dragonsType.Key][1] += dragon.Value[1];
                    typesDict[dragonsType.Key][2] += dragon.Value[2];
                    typesDict[dragonsType.Key][3]++;
                }
            }

            foreach (var dragonTypes in dragonArmy)
            {
                typesDict[dragonTypes.Key][0] = Math.Round(typesDict[dragonTypes.Key][0] / typesDict[dragonTypes.Key][3], 2);
                typesDict[dragonTypes.Key][1] = Math.Round(typesDict[dragonTypes.Key][1] / typesDict[dragonTypes.Key][3], 2);
                typesDict[dragonTypes.Key][2] = Math.Round(typesDict[dragonTypes.Key][2] / typesDict[dragonTypes.Key][3], 2);
                Console.WriteLine($"{dragonTypes.Key}::({typesDict[dragonTypes.Key][0]:f2}/{typesDict[dragonTypes.Key][1]:f2}/{typesDict[dragonTypes.Key][2]:f2})");
                foreach (var dragonNames in dragonTypes.Value)
                {
                    Console.WriteLine($"-{dragonNames.Key} -> damage: {dragonNames.Value[0]}, health: {dragonNames.Value[1]}, armor: {dragonNames.Value[2]}");
                }
            }
        }
    }
}
