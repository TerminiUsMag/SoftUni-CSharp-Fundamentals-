using System;
using System.Collections.Generic;
using System.Linq;

namespace _03._Legendary_Farming
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Shadowmourne - requires 250 Shards;
            //Valanyr - requires 250 Fragments;
            //Dragonwrath - requires 250 Motes;
            bool itemIsAquired = false;
            Dictionary<string, int> items = new Dictionary<string, int>()
            {
                ["shards"] = 0,
                ["motes"] = 0,
                ["fragments"] = 0
            };
            while (!itemIsAquired)
            {
                string command = Console.ReadLine().ToLower();
                string[] commandTokens = command.Split(' ');
                for (int i = 0; i < commandTokens.Length; i += 2)
                {
                    if (!items.ContainsKey(commandTokens[i + 1]))
                    {
                        items.Add(commandTokens[i + 1], 0);
                    }

                    items[commandTokens[i + 1]] += int.Parse(commandTokens[i]);
                    if (items["shards"] >= 250 || items["fragments"] >= 250 || items["motes"] >= 250)
                    {
                        itemIsAquired = true;
                        break;
                    }
                }
                if (items["shards"] >= 250)
                {
                    items["shards"] -= 250;
                    Console.WriteLine("Shadowmourne obtained!");
                }
                else if (items["fragments"] >= 250)
                {
                    items["fragments"] -= 250;
                    Console.WriteLine("Valanyr obtained!");
                }
                else if (items["motes"] >= 250)
                {
                    items["motes"] -= 250;
                    Console.WriteLine("Dragonwrath obtained!");
                }

            }
            foreach (var item in items)
            {
                Console.WriteLine($"{item.Key}: {item.Value}");
            }
        }
    }
}
