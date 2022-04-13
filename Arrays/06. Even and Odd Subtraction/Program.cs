using System;
using System.Linq;

namespace _06._Even_and_Odd_Subtraction
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();
            int even =0, odd =0;
            foreach(int i in arr)
            {
                if (i % 2 == 0) even += i;
                if (i % 2 != 0) odd += i;
            }
            Console.WriteLine(even-odd);
        }
    }
}
