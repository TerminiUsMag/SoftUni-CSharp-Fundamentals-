using System;
using System.Collections.Generic;
using System.Linq;

namespace _05._Remove_Negatives_and_Reverse
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> numberList = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();

            for (int i = 0; i < numberList.Count; i++)
            {
                if (numberList[i] < 0)
                {
                    numberList.Remove(numberList[i]);
                    i -= 1;
                }
            }

            if (numberList.Count == 0)
            {
                Console.WriteLine("empty");
                return;
            }
            else
            {
                numberList.Reverse();
            }
            Console.WriteLine(String.Join(' ', numberList));
        }
    }
}
