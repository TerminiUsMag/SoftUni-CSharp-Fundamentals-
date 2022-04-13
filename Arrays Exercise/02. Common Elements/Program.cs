using System;

namespace _02._Common_Elements
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] firstArray = Console.ReadLine().Split();
            string[] secondArray = Console.ReadLine().Split();
            int maxIndex = 0, minIndex = 0, counter = 0;
            if (firstArray.Length > secondArray.Length)
            {
                maxIndex = firstArray.Length - 1;
                minIndex = secondArray.Length - 1;
            }
            else
            {
                maxIndex = secondArray.Length - 1;
                minIndex = firstArray.Length - 1;
            }
            string[] sumArray = new string[maxIndex];
            for (int i = 0; i <= firstArray.Length - 1; i++)
            {
                for (int j = 0; j <= secondArray.Length - 1; j++)
                {
                    if (firstArray[i] == secondArray[j])
                    {
                        sumArray[counter] = firstArray[i];
                        counter++;
                    }
                }
            }
            Console.WriteLine(String.Join(' ',sumArray));

        }
    }
}
