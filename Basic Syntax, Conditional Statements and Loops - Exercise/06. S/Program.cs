using System;

namespace _06._S
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string number = Console.ReadLine();
            long sumFactorial = 0;

            for (int i = 0; i < number.Length; i++)
            {
                char currCh = number[i];
                int currDigit = currCh - '0';

                long currDigitFactorial = 1;
                for (int j = currDigit; j > 1; j--)
                {
                    currDigitFactorial *= j;
                }
                sumFactorial += currDigitFactorial;
            }
            if(sumFactorial == int.Parse(number))
            {
                Console.WriteLine("yes");
            }
            else Console.WriteLine("no");
        }
    }
}
