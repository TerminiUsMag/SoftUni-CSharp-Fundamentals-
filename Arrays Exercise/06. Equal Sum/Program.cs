using System;
using System.Linq;

namespace _06._Equal_Sum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numArray = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int leftSum = 0, rightSum = 0, resultIndex = -1;

            for (int i = 0; i < numArray.Length; i++)
            {
                for (int j = i-1; j >= 0; j--)
                {
                    leftSum += numArray[j];
                }
                for (int k = i+1; k < numArray.Length; k++)
                {
                    rightSum += numArray[k];
                }
                if (leftSum == rightSum)
                {
                    resultIndex = i;
                    break;
                }
                resultIndex = -1;
                leftSum = 0;
                rightSum = 0;
            }
            if (resultIndex != -1)
                Console.WriteLine(resultIndex);
            else
                Console.WriteLine("no");
        }
    }
}
