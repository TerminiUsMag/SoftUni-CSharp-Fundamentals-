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
            var dragonArmy = new Dictionary<string, Dictionary<string, List<int>>>();

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
                if(command[3] == "null")
                {
                    health = 250;
                }
                else
                {
                    health = int.Parse(command[3]);
                }
                if(command[4] == "null")
                {
                    armor = 10;
                }
                else
                {
                    armor = int.Parse(command[4]);
                }

                var newList = new List<int>();
                newList.Add(damage);
                newList.Add(health);
                newList.Add(armor);
                var newDict = new Dictionary<string , List<int>>();
                newDict.Add(name, newList);
                dragonArmy.Add(type, newDict);

            }
        }
    }
}
