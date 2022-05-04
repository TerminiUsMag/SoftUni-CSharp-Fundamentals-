using System;
using System.Collections.Generic;
using System.Linq;

namespace _04._Snowwhite
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string command;

            var dwarfDict = new Dictionary<string, Dictionary<string, int>>();

            while ((command = Console.ReadLine()) != "Once upon a time")
            {
                string[] commandTokens = command.Split("<:>", StringSplitOptions.RemoveEmptyEntries);

                string dwarfName = commandTokens[0];
                string dwarfHatColor = commandTokens[1];
                int dwarfPhysics = int.Parse(commandTokens[2]);

                if (dwarfDict.ContainsKey(dwarfHatColor))
                {
                    if (dwarfDict[dwarfHatColor].ContainsKey(dwarfName))
                    {
                        if (dwarfDict[dwarfHatColor][dwarfName] < dwarfPhysics)
                        {
                            dwarfDict[dwarfHatColor][dwarfName] = dwarfPhysics;
                        }
                    }
                    else
                    {
                        dwarfDict[dwarfHatColor].Add(dwarfName, dwarfPhysics);
                    }
                }
                else
                {
                    var newDict = new Dictionary<string, int>();
                    newDict[dwarfName] = dwarfPhysics;
                    dwarfDict.Add(dwarfHatColor, newDict);
                }
            }

            var orderedDwarfDict = dwarfDict
                .OrderByDescending(x=>x.Value.OrderByDescending(x=>x.Value))
                .ThenByDescending(x=>x.Value.Count)
                .ToDictionary(x=>x.Key,x=>x.Value);

            foreach(var color in orderedDwarfDict)
            {
                foreach(var dwarf in color.Value)
                {

                }
            }
        }
    }
}
