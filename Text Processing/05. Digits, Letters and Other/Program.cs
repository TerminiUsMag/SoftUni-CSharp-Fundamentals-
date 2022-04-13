using System;

namespace _05._Digits__Letters_and_Other
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Create a program that receives a single string and on the first 
            //line prints all the digits, on the second – all the letters,
            //and on the third – all the other characters. There will always 
            //be at least one digit, one letter, and one other character.

            char[] chars = Console.ReadLine().ToCharArray();
            string digits = string.Empty;
            string letters = string.Empty;
            string others = string.Empty;
            foreach (char c in chars)
            {
                if (char.IsDigit(c))
                {
                    digits += c;
                }
                else if (char.IsLetter(c))
                {
                    letters += c;
                }
                else
                {
                    others += c;
                }
            }
            Console.WriteLine(digits);
            Console.WriteLine(letters);
            Console.WriteLine(others);
        }
    }
}
