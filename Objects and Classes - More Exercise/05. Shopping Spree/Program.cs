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
        public void AddProduct(Product product)
        {
            if (product.Cost > this.Money)
            {
                Console.WriteLine($"{this.Name} can't afford {product.Name}");
            }
            else if (product.Cost <= this.Money)
            {
                this.Money -= product.Cost;
                this.Bag.Add(product);
                Console.WriteLine($"{this.Name} bought {product.Name}");
            }
        }
        public void ShoppingBag()
        {
            if (Bag.Count == 0)
            {
                Console.WriteLine($"{this.Name} - Nothing bought");
            }
            else
            {
                Console.WriteLine($"{this.Name} - ");
                if (this.Bag.Count > 1)
                {
                    //foreach (Product product in Bag)
                    //{
                    //    if (Bag.Last().Name == product.Name && Bag.Last().Cost == product.Cost)
                    //    {
                    //        Console.WriteLine($"{product.Name}");
                    //    }
                    //    else
                    //    {
                    //        Console.Write($"{product.Name}, ");
                    //    }
                    //}
                    for (int i = 0; i < this.Bag.Count; i++)
                    {
                        if (i == this.Bag.Count - 1)
                        {
                            Console.Write($"{this.Bag[i].Name}");
                        }
                        else
                        {
                            Console.Write($"{this.Bag[i].Name}, ");
                        }
                    }
                }
            }
        }
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

            string command;
            while ((command = Console.ReadLine()) != "END")
            {
                string[] input = command.Split(' ', StringSplitOptions.RemoveEmptyEntries).ToArray();
                string name = input[0];
                string productName = input[1];

                foreach (var person in people)
                {
                    if (person.Name == name)
                    {
                        foreach (var product2 in products)
                        {
                            if (product2.Name == productName)
                            {
                                person.AddProduct(product2);
                            }
                        }
                    }
                }

                foreach (var person in people)
                {
                    person.ShoppingBag();
                }
            }
        }
    }
}
