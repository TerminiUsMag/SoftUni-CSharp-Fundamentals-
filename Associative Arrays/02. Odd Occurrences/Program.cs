using System;
using System.Collections.Generic;

namespace _02._Odd_Occurrences
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] words = Console.ReadLine().Split(' ');
            Dictionary<string, int> occurencies = new Dictionary<string, int>();

            foreach (string word in words)
            {
                string currentWord = word.ToLower();
                if (occurencies.ContainsKey(currentWord))
                {
                    occurencies[currentWord]++;
                }
                else
                {
                    occurencies.Add(currentWord, 1);
                }
            }
            foreach (var item in occurencies)
            {
                if (item.Value % 2 != 0)
                {
                    Console.Write(item.Key + " ");
                }
            }

        }
    }
}
