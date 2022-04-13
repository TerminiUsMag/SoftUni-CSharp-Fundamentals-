using System;
using System.Collections.Generic;

namespace _03._Word_Synonyms
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int countOfPairs = int.Parse(Console.ReadLine());
            Dictionary<string, List<string>> pairs = new Dictionary<string, List<string>>();

            for (int i = 0; i < countOfPairs; i++)
            {
                string word = Console.ReadLine();
                string synonym = Console.ReadLine();

                if (pairs.ContainsKey(word))
                {
                    pairs[word].Add(synonym);
                }
                else
                {
                    pairs.Add(word, new List<string>()
                    {
                        synonym,
                    });
                }
            }
            foreach (var item in pairs)
            {
                Console.WriteLine($"{item.Key} - {String.Join(", ", item.Value)}");
            }
        }
    }
}
