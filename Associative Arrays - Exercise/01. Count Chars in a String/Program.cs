using System;
using System.Linq;
using System.Collections.Generic;

namespace _01._Count_Chars_in_a_String
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            Dictionary<char, int> dic = new Dictionary<char, int>();

            foreach (char c in input)
            {
                if (c != ' ')
                {
                    if (!dic.ContainsKey(c))
                    {
                        dic.Add(c, 0);
                    }
                    dic[c]++;
                }
            }
            foreach (var item in dic)
            {
                Console.WriteLine($"{item.Key} -> {item.Value}");
            }
        }
    }
}
