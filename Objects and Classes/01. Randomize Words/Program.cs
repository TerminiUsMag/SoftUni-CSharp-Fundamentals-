using System;

namespace _01._Randomize_Words
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] words = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);

            Random rand = new Random();


            for (int i = 0; i < words.Length; i++)
            {
                int randIndex = rand.Next(0, words.Length);
                string currentWord = words[i];
                words[i] = words[randIndex];
                words[randIndex] = currentWord;
            }
            foreach (string word in words)
            {
                Console.WriteLine(word);
            }


        }
    }
}
