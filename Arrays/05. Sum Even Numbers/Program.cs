using System;
using System.Linq;

namespace _05._Sum_Even_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int [] arr = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();
            int sum = 0;
            foreach(int i in arr)
            {
                if (i % 2 == 0) sum += i;
            }
            Console.WriteLine(sum);
        }
    }
}
