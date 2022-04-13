using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace _06._Replace_Repeating_Chars
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            char[] inputCharArray = input
                .ToCharArray();

            List<char> inputCharList = input
                .ToList();

            List<int> indexesToRemove = new List<int>();

            //Dictionary<char, Dictionary<int, int>> repeatingChars = new Dictionary<char, Dictionary<int, int>>();

            //for (int i = 0; i < input.Length - 1; i++)
            //{
            //    char currentChar = input[i];
            //    char nextChar = input[i + 1];
            //    if (currentChar == nextChar)
            //    {
            //        if (!repeatingChars.ContainsKey(currentChar))
            //        {
            //            repeatingChars.Add(currentChar, new Dictionary<int, int>() { [i] = 0});
            //        }
            //        repeatingChars[currentChar][i]++;
            //    }
            //}

            for (int i = 0; i < inputCharList.Count - 1; i++)
            {
                char currentChar = inputCharList[i];
                char nextChar = inputCharList[i + 1];
                if (currentChar == nextChar)
                {
                    indexesToRemove.Add(i);
                }
            }

            indexesToRemove.Reverse();

            foreach(var index in indexesToRemove)
            {
                inputCharList.RemoveAt(index);
            }
            string outputString = string.Join("", inputCharList);
            Console.WriteLine(outputString);

        }
    }
}
