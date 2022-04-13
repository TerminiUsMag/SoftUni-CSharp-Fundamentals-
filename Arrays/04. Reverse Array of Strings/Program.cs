using System;

namespace _04._Reverse_Array_of_Strings
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] normalArray = Console.ReadLine().Split(' ');
            string[] reverseArray = new string[normalArray.Length];
            int counter = normalArray.Length;
            for (int i = 0; i < normalArray.Length; i++)
            {
                counter--;
                reverseArray[i] = normalArray[counter];
            }
            Console.Write(string.Join(' ',reverseArray));
        }
    }
}
