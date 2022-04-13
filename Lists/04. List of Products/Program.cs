using System;
using System.Collections.Generic;

namespace _04._List_of_Products
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numberOfProducts = int.Parse(Console.ReadLine());

            List<string> products = new List<string>();

            for(int i = 0; i < numberOfProducts; i++)
            {
                string product = Console.ReadLine();
                products.Add(product);
            }
            products.Sort();

            for(int j = 0; j < products.Count; j++)
            {
                Console.WriteLine($"{j+1}.{products[j]}");
            }
        }
    }
}
