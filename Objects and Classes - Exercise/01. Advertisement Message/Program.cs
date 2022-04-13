using System;
using System.Collections.Generic;

namespace _01._Advertisement_Message
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] phrases = { "Excellent product.", "Such a great product.", "I always use that product.", "Best product of its category.", "Exceptional product.", "I can’t live without this product." };
            string[] events = { "Now I feel good.", "I have succeeded with this product.", "Makes miracles. I am happy of the results!", "I cannot believe but now I feel awesome.", "Try it yourself, I am very satisfied.", "I feel great!" };
            string[] authors = { "Diana", "Petya", "Stella", "Elena", "Katya", "Iva", "Annie", "Eva" };
            string[] cities = { "Burgas", "Sofia", "Plovdiv", "Varna", "Ruse" };

            Random r = new Random();

            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                int rand = r.Next(0, phrases.Length);
                Console.Write($"{phrases[rand]}");
                rand = r.Next(0, events.Length);
                Console.Write($"{events[rand]}");
                rand = r.Next(0, authors.Length);
                Console.Write(authors[rand]);
                rand = r.Next(0, cities.Length);
                Console.Write($"{cities[rand]}\n");


            }

        }
    }
}
