using System;
using System.Linq;

namespace _07._Max_Sequence_of_Equal_Elements
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbersArray = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int numberForSequence = 0, maxSequence = 0, maxSequenceNum = 0, sequence = 1, sequenceNum = 0;
            bool lastNum = false;

            for (int i = 0; i < numbersArray.Length; i++)
            {
                numberForSequence = numbersArray[i];
                lastNum = true;
                for (int j = i+1; j < numbersArray.Length; j++)
                {
                    if (numberForSequence == numbersArray[j] && lastNum)
                    {
                        sequence++;
                        sequenceNum = numberForSequence;
                        lastNum = true;
                    }
                    else
                    {
                        lastNum = false;

                    }
                }
                if (sequence > maxSequence)
                {
                    maxSequence = sequence;
                    maxSequenceNum = sequenceNum;
                }
                sequence = 1;
            }
            for(int k= 0; k < maxSequence; k++)
            {
                Console.Write(maxSequenceNum + " ");
            }
        }
    }
}
