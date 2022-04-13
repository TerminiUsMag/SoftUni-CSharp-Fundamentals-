using System;
using System.Collections.Generic;
using System.Linq;

namespace _03._Phone_Shop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> phones = Console.ReadLine()
               .Split(", ")
               .ToList();
            List<string> command = Console.ReadLine()
                .Split(' ', ':')
                .ToList();
            //Add - add the given phone to the storage (if it already exists, skip the operation).
            //Remove - remove the phone from the storage if it exists, otherwise skip the command.
            //Bonus Phone - {OLD ONE}:{NEW ONE} if the old one exists add the new one after the old one(otherwise skip the command).
            //Last - if the given phone exists you should change its position and put it last in your storage(if the phone doesn't exist ignore the command).
            while (command[0] != "End")
            {
                bool exists = false;
                bool exists2 = false;
                int bf = 0;
                if (command[0] == "Add")
                {
                    for (int i = 0; i < phones.Count; i++)
                    {
                        if (command[2] == phones[i]) exists = true;
                    }
                    if (!exists) phones.Add(command[2]);
                }
                if (command[0] == "Remove")
                {
                    for (int i = 0; i < phones.Count; i++)
                    {
                        if (command[2] == phones[i]) exists = true;
                    }
                    if (exists) phones.Remove(command[2]);
                    //phones.Remove(command[2]);
                }
                if (command[0] == "Bonus")
                {
                    for (int i = 0; i < phones.Count; i++)
                    {
                        if (command[3] == phones[i])
                        {
                            exists = true;
                            bf = i;
                        }
                        if (command[4] == phones[i])
                        {
                            exists2 = true;
                        }
                    }
                    if (exists && !exists2) phones.Insert(bf + 1, command[4]);

                }
                if (command[0] == "Last")
                {
                    for (int i = 0; i < phones.Count; i++)
                    {
                        if (command[2] == phones[i])
                        {
                            exists = true;
                        }
                    }
                    if (exists)
                    {
                    phones.Remove(command[2]);
                    phones.Add(command[2]);
                    }
                }
                command = Console.ReadLine().Split(' ', ':').ToList();
            }
            Console.WriteLine(string.Join(", ", phones));
        }
    }
}
