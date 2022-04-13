using System;
using System.Text;

namespace _04._Caesar_Cipher
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string inputText = Console.ReadLine();
            char[] inputChars = inputText.ToCharArray();

            StringBuilder sb = new StringBuilder();
            sb.Append(inputText);

            for (int i = 0; i < inputChars.Length; i++)
            {

                int currentChar = inputChars[i];
                currentChar += 3;
                inputChars[i] = (char)currentChar;
            }
            string result = new string(inputChars);
            Console.WriteLine(result);
        }
    }
}
