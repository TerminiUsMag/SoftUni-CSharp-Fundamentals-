using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _05._Multiply_Big_Number
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ////int[] firstNum = Console.ReadLine()
            ////    .Split()
            ////    .Select(int.Parse)
            ////    .ToArray();

            //string firstNum = Console.ReadLine();
            //char[] firstNumCharArray = firstNum.ToCharArray();
            //int[] firstNumInt = firstNumCharArray.Select(x => x - '0').ToArray();

            //int secondNum = int.Parse(Console.ReadLine());
            //string result = string.Empty;
            ////result+= secondNum.ToString();
            //int ostatuk = 0;
            //for (int i = 0; i < firstNumInt.Length; i++)
            //{
            //    int resultInInt = firstNumInt[i] * secondNum;
            //    while (resultInInt > 9)
            //    {
            //        resultInInt--;
            //        ostatuk++;
            //    }
            //    if(resultInInt+ostatuk <= 9)
            //    {
            //        resultInInt += ostatuk;
            //        ostatuk = 0;
            //    }
            //    result += resultInInt.ToString();
            //}

            //Console.WriteLine(result);
            string number = Console.ReadLine();
            List<int> number1 = new List<int>();
            foreach (var item in number.Reverse())
            {
                number1.Add((int)Char.GetNumericValue(item));
            }
            int number2 = int.Parse(Console.ReadLine());
            StringBuilder result = new StringBuilder();
            if (number == "0" || number2 == 0)
            {
                Console.WriteLine("0");
            }
            else
            {
                int rest = 0;
                int baseNum = 0;
                foreach (var item in number1)
                {
                    int current = item * number2 + rest;
                    baseNum = current % 10;
                    rest = current / 10;
                    result.Append(baseNum);
                }
                if (rest != 0)
                {
                    result.Append(rest);
                }
                string resultStr = result.ToString();
                char[] reversedArr = resultStr.ToCharArray();
                Array.Reverse(reversedArr);
                resultStr = new String(reversedArr);
                Console.WriteLine(resultStr);
            }
        }
    }
}