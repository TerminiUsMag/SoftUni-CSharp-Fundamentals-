using System;
using System.Linq;

namespace Demo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //int[] numberArray = new int[6];
            //numberArray[0] = 1;
            //numberArray[1] = 2;
            //numberArray[2] = 3;
            //numberArray[4] = 5;
            //numberArray[5] = 6;
            //int[] numberArray2 = new int[7];
            //numberArray2[3] = 4;
            //numberArray2[6] = 7;
            //numberArray2 = numberArray;

            //string input = Console.ReadLine();
            //string[] inputArray = input.Split(' ');
            //int[] numberArray = new int[inputArray.Length];
            //for(int i = 0; i < inputArray.Length; i++)
            //{
            //    numberArray[i] = int.Parse(inputArray[i]);
            //}

            int[] numbersArray = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            //for(int i = 0; i < numbersArray.Length; i++)
            //{
            //    Console.WriteLine(numbersArray[i]);
            //}
            Console.WriteLine(string.Join(' ', numbersArray));
        }
    }
}
