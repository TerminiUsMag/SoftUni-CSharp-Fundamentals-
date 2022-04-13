using System;
using System.Linq;

namespace _00._DEMO
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            char[] chars = input.ToCharArray();

            chars[2] = ' ';
            chars = chars.Where(x => !x.Equals(' ')).ToArray();
            Console.WriteLine(string.Join("", chars));
        }
    }
}
