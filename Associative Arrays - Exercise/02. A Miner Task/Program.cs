using System;
using System.Linq;
using System.Collections.Generic;

namespace _02._A_Miner_Task
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> resQuantity = new Dictionary<string, int>();

            string resource = Console.ReadLine();

            while (resource != "stop")
            {
                if (!resQuantity.ContainsKey(resource))
                {
                    resQuantity.Add(resource, 0);
                }
                int quantity = int.Parse(Console.ReadLine());
                resQuantity[resource] += quantity;
                resource = Console.ReadLine();
            }
            foreach (var item in resQuantity)
            {
                Console.WriteLine($"{item.Key} -> {item.Value}");
            }
        }
    }
}
