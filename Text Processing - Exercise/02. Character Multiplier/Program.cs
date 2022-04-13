using System;

namespace _02._Character_Multiplier
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] stringsArray = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);
            int result = CharacterMultiply(stringsArray[0], stringsArray[1]);

            Console.WriteLine(result);
        }
        static int CharacterMultiply(string str1, string str2)
        {
            int shorterStringLenght = 0, result = 0;
            int stringDifference = Math.Abs(str1.Length - str2.Length);
            string shorterString = string.Empty;
            if (str1.Length > str2.Length)
            {
                shorterStringLenght = str2.Length;
                shorterString = str2;
            }
            else
            {
                shorterStringLenght = str1.Length;
                shorterString = str1;
            }

            for (int i = 0; i < shorterStringLenght; i++)
            {
                int c1 = str1[i];
                int c2 = str2[i];
                result += c1 * c2;
            }
            for (int i = shorterStringLenght; i < shorterStringLenght + stringDifference; i++)
            {
                if (shorterString == str1)
                {
                    result += str2[i];
                }
                else if (shorterString == str2)
                {
                    result += str1[i];
                }
            }

            return result;
        }
    }
}
