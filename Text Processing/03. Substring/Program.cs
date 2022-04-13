using System;

namespace _03._Substring
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] wordsToRemove = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);
            string lineToRemoveFrom = Console.ReadLine();

            foreach (string word in wordsToRemove)
            {
                while (lineToRemoveFrom.Contains(word))
                {
                    lineToRemoveFrom = lineToRemoveFrom.Replace(word, "");
                }
            }
            Console.WriteLine(lineToRemoveFrom);
        }
    }
}
