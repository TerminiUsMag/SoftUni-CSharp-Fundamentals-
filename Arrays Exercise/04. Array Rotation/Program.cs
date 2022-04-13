using System;
using System.Linq;

namespace _04._Array_Rotation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] inputArray = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToArray();

            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                int temp = inputArray[0];
                for (int j = 0; j < inputArray.Length; j++)
                {
                    if (j == inputArray.Length)
                        inputArray[j] = temp;
                    else
                        inputArray[i] = inputArray[i + 1];
                }
            }
            Console.WriteLine(String.Join(" ", inputArray));
        }
    }
}
