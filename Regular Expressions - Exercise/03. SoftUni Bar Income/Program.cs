using System;
using System.Text.RegularExpressions;
using System.Linq;

namespace _03._SoftUni_Bar_Income
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string pattern = @"%(?<name>[A-Z][a-z]+)%[^\%\|\$\.]*<(?<product>\w+)>[^\%\|\$\.]*\|(?<count>\d+)\|(?<price>\d+(\.\d+)?)\$";

            string command;

            double totalIncome = 0;

            while ((command = Console.ReadLine()) != "end of shift")
            {
                Match match = Regex.Match(command, pattern);

                if (!match.Success)
                {
                    continue;
                }

                string customerName = match.Groups["name"].Value;
                string product = match.Groups["product"].Value;
                int count = int.Parse(match.Groups["count"].Value);
                double price = double.Parse(match.Groups["price"].Value);
                double totalPrice = count * price;
                totalIncome += totalPrice;

                Console.WriteLine($"{customerName}: {product} - {totalPrice:f2}");

            }

            Console.WriteLine($"Total income: {totalIncome:f2}");




        }
    }
}
