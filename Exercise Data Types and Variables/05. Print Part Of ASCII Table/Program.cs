using System;

namespace _05._Print_Part_Of_ASCII_Table
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int n1 = int.Parse(Console.ReadLine());
            for(int i = n; i <= n1; i++)
            {
                char c = ' ';
                c = (char)i;
                Console.Write($"{c} ");
            }

        }
    }
}
