using System;
using System.Linq;

namespace _05._Top_Integers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] inputArray = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToArray();
            int[] topIntegers = new int[inputArray.Length];
            bool isTopInt = false, isLastInt = false;

            for (int i = 0; i < inputArray.Length; i++)
            {
                if (i == inputArray.Length - 1) isLastInt = true;
                for (int j = i + 1; j < inputArray.Length; j++)
                {
                    if (inputArray[i] > inputArray[j]) isTopInt = true;
                    else
                    {
                        isTopInt = false;
                        break;
                    }
                }
                if (isTopInt || isLastInt)
                {
                    Console.Write(inputArray[i] + " ");
                }
                isTopInt = false;
            }

        }
    }
}
