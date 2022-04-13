using System;
using System.Collections.Generic;
using System.Linq;

namespace _04._Orders
{
    class Product
    {
        public Product(string name, double price)
        {
            this.ProductName = name;
            this.Price = price;
        }
        public string ProductName { get; set; }
        public double Price { get; set; }

    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<double>> products = new Dictionary<string, List<double>>();

            string command = Console.ReadLine();
            while (command != "buy")
            {
                string[] commandTokens = command.Split(' ', StringSplitOptions.RemoveEmptyEntries);

                if (!products.ContainsKey(commandTokens[0]))
                {
                    List<double> productInfo = new List<double> { double.Parse(commandTokens[1]), double.Parse(commandTokens[2]) };
                    products[commandTokens[0]] = productInfo;
                }
                else
                {
                    products[commandTokens[0]][0] = double.Parse(commandTokens[1]);
                    products[commandTokens[0]][1] += double.Parse(commandTokens[2]);
                }

                command = Console.ReadLine();
            }
            foreach (var prod in products)
            {
                Console.WriteLine($"{prod.Key} -> {prod.Value[0] * prod.Value[1]:f2}");
            }
        }
    }
}
