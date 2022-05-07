using System;
using System.Collections.Generic;
using System.Linq;

namespace _05._Shopping_Spree
{
    class Product
    {
        public Product(string name, double cost)
        {
            this.Name = name;
            this.Cost = cost;
        }
        public double Cost { get; set; }
        public string Name { get; set; }
    }
    class Person
    {
        public Person(string name, double money)
        {
            this.Name = name;
            this.Money = money;
            this.Bag = new List<Product>();
        }
        public double Money { get; set; }
        public string Name { get; set; }
        public List<Product> Bag { get; set; }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            var people = new List<Person>();
            var products = new List<Product>();


            string[] rawInputPeople = Console.ReadLine().Split(';', StringSplitOptions.RemoveEmptyEntries);

            for (int i = 0; i < rawInputPeople.Length; i++)
            {
                string[] info = rawInputPeople[i].Split('=', StringSplitOptions.RemoveEmptyEntries);
                string name = info[0];
                double money = double.Parse(info[1]);

                var newPerson = new Person(name, money);
                people.Add(newPerson);
            }
            string[] rawInputProducts = Console.ReadLine().Split(';', StringSplitOptions.RemoveEmptyEntries);

            for (int x = 0; x < rawInputProducts.Length; x++)
            {
                string[] info = rawInputProducts[x].Split('=', StringSplitOptions.RemoveEmptyEntries);
                string name = info[0];
                double cost = double.Parse(info[1]);

                var newProduct = new Product(name, cost);
                products.Add(newProduct);
            }
        }
    }
}
