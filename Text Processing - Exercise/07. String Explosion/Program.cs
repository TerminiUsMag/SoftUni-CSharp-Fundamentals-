using System;
using System.Collections.Generic;
using System.Linq;

namespace _07._String_Explosion
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            //List<char> inputCharList = input.ToList();

            //Dictionary<int, int> rangeToRemove = new Dictionary<int, int>();

            //int saveStrenght = 0;

            //for (int i = 0; i < inputCharList.Count - 3; i++)
            //{
            //    char currentChar = inputCharList[i];
            //    char charOfStrenght = inputCharList[i + 1];
            //    char nextAfterNextChar = inputCharList[i + 2];

            //    //if (nextAfterNextChar == '>' && currentChar == '>')
            //    //{
            //    //    saveStrenght += charOfStrenght;

            //    //    continue;
            //    //}

            //    if (currentChar == '>')
            //    {
            //        int strenght = (int)char.GetNumericValue(charOfStrenght);
            //        rangeToRemove.Add(i + strenght, i);
            //    }
            //}

            //var rangeToRemoveReversed = rangeToRemove.Reverse();


            //foreach (var item in rangeToRemoveReversed)
            //{
            //    for (int x = item.Key; x >= item.Value; x--)
            //    {
            //        char currentChar = inputCharList[x];
            //        if (currentChar != '>')
            //        {
            //            inputCharList.RemoveAt(x);
            //        }
            //    }
            //}

            //Console.WriteLine(String.Join("", inputCharList));

            //char[] inputCharArray = input.ToCharArray();

            //int strenght = 0;
            //for (int i = 0; i < inputCharArray.Length - 3; i++)
            //{
            //    char currentChar = inputCharArray[i];
            //    char nextChar = inputCharArray[i + 1];
            //    char thirdChar = inputCharArray[i + 2];
            //    char fourthChar = inputCharArray[i + 3];

            //    if (currentChar == '>')
            //    {
            //        strenght = (int)char.GetNumericValue(nextChar);
            //        inputCharArray[i + 1] = ' ';
            //        strenght--;
            //        if (thirdChar == '>')
            //        {
            //            strenght += (int)char.GetNumericValue(fourthChar);
            //            inputCharArray[i + 3] = ' ';
            //            strenght--;
            //            i += 3;
            //        }
            //        else
            //        {
            //            i++;
            //        }

            //    }
            //    else if (strenght != 0)
            //    {
            //        inputCharArray[i] = ' ';
            //        strenght--;
            //    }
            //}

            //int c = 0;
            //for (int i = 0; i < inputCharArray.Length - 1; i++)
            //{
            //    c = 0;
            //    char currentChar = inputCharArray[i];
            //    if (currentChar == '>')
            //    {
            //        strenght += (int)char.GetNumericValue(inputCharArray[i + 1]);
            //        int s = 0;
            //        while (s < strenght)
            //        {

            //            if (inputCharArray[i + s] != '>')
            //            {
            //                inputCharArray[i + s] = ' ';
            //                c++;
            //                s++;
            //            }
            //            else
            //            {
            //                strenght += (int)char.GetNumericValue(inputCharArray[i + s + 1]);
            //                inputCharArray[i + s + 1] = ' ';
            //                c += 2;
            //                s++;
            //            }
            //        }
            //        i += c;
            //    }
            //}

            //char[] output = inputCharArray.Where(x => x != ' ').ToArray();

            //Console.WriteLine(String.Join("", output));

            int bomb = 0;
            for (int i = 0; i < input.Length; i++)
            {
                char currentChar = input[i];
                if (bomb > 0 && currentChar != '>')
                {
                    input = input.Remove(i, 1);
                    bomb--;
                    i--;
                }
                else if (currentChar == '>')
                {
                    bomb += int.Parse(input[i+1].ToString());
                }
            }
            Console.WriteLine(input);

        }
    }
}
