using System;
using System.Text;

namespace _02._Repeat_Strings
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] words = Console.ReadLine().Split(' ');

            StringBuilder sb = new StringBuilder();

            foreach (string word in words)
            {
                for (int x = 0; x < word.Length; x++)
                {
                    sb.Append(word);
                }
            }

            Console.WriteLine(sb);
        }
    }
}
