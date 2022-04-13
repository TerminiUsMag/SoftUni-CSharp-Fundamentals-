using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace _01._Furniture
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //>> ([A - Za - z] +) << (\d +|\d +\.\d +)!([0 - 9] +)\b
            //>> (\w +)<< (\d +|\d +\.\d +)!(\d +)\b
            string pattern = @"[>]{2}(?<name>[A-Za-z]+)[<]{2}(?<price>\d+(\.\d+)?)\!(?<quantity>\d+)";
            List<string> list = new List<string>();
            double result = 0;

            string input;
            while ((input = Console.ReadLine()) != "Purchase")
            {
                Match match = Regex.Match(input, pattern);
                if (!match.Success)
                {
                    continue;
                }
                string name = match.Groups["name"].Value;
                double price = double.Parse(match.Groups["price"].Value);
                int quantity = int.Parse(match.Groups["quantity"].Value);

                list.Add(name);
                result += price * quantity;

            }
            Console.WriteLine("Bought furniture:");
            if (list.Count > 0)
            {
                Console.WriteLine(String.Join("\n", list));
            }
            Console.WriteLine($"Total money spend: {result:f2}");
        }
    }
}
