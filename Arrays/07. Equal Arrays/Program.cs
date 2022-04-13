using System;
using System.Linq;

namespace _07._Equal_Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int[] arr2 = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int diffIndex = -1, sum = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr2[i] != arr[i])
                {
                    diffIndex = i;
                    break;
                }
                sum += arr[i];
            }
            if (diffIndex == -1) Console.WriteLine($"Arrays are identical. Sum: {sum}");
            else Console.WriteLine($"Arrays are not identical. Found difference at {diffIndex} index");
        }
    }
}
