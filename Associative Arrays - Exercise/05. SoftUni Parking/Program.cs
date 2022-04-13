using System;
using System.Linq;
using System.Collections.Generic;

namespace _05._SoftUni_Parking
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //The program receives 2 commands:
            //            "register {username} {licensePlateNumber}":
            //The system only supports one car per user at the moment, so if a user tries to register another license plate, using the same username, the system should print:
            //"ERROR: already registered with plate number {licensePlateNumber}"
            //If the aforementioned checks passes successfully, the plate can be registered, so the system should print:
            // "{username} registered {licensePlateNumber} successfully"
            //"unregister {username}":
            //If the user is not present in the database, the system should print:
            //            "ERROR: user {username} not found"
            //If the aforementioned check passes successfully, the system should print:
            //            "{username} unregistered successfully"

            int numberOfCommands = int.Parse(Console.ReadLine());

            Dictionary<string, string> parking = new Dictionary<string, string>();

            for (int i = 0; i < numberOfCommands; i++)
            {
                string[] command = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);

                if (command[0] == "register")
                {
                    if (parking.ContainsKey(command[1]))
                    {
                        Console.WriteLine($"ERROR: already registered with plate number {parking[command[1]]}");
                    }
                    else
                    {
                        parking.Add(command[1], command[2]);
                        Console.WriteLine($"{command[1]} registered {command[2]} successfully");
                    }
                }
                else if (command[0] == "unregister")
                {
                    if (!parking.ContainsKey(command[1]))
                    {
                        Console.WriteLine($"ERROR: user {command[1]} not found");
                    }
                    else
                    {
                        parking.Remove(command[1]);
                        Console.WriteLine($"{command[1]} unregistered successfully");
                    }
                }
            }

            foreach (var item in parking)
            {
                Console.WriteLine($"{item.Key} => {item.Value}");
            }

        }
    }
}
