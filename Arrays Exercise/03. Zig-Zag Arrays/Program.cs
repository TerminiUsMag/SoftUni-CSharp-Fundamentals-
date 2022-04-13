using System;
using System.Linq;

namespace _03._Zig_Zag_Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] firstArray = new int[n];
            int[] secondArray = new int[n];

            for (int i = 0; i < n; i++)
            {
                int[] tempArray = Console.ReadLine()
                    .Split()
                    .Select(int.Parse)
                    .ToArray();
                if (i % 2 == 0)
                {
                    firstArray[i] = tempArray[0];
                    secondArray[i] = tempArray[1];
                }
                else
                {
                    secondArray[i] = tempArray[0];
                    firstArray[i] = tempArray[1];
                }
            }
            Console.WriteLine(String.Join(' ', firstArray));
            Console.WriteLine(String.Join(' ', secondArray));
        }
    }
}
