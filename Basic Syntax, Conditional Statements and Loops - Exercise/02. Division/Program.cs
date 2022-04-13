using System;

namespace _02._Division
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            int divided = 0;
            if (num % 2 == 0) divided = 2;
            if (num % 3 == 0) divided = 3;
            if (num % 6 == 0) divided = 6;
            if (num % 7 == 0) divided = 7;
            if (num % 10 == 0) divided = 10;
            if (divided != 0)
            {
                Console.WriteLine($"The number is divisible by {divided}");
            }
            else
            {
                Console.WriteLine("Not divisible");
            }
        }
    }
}
