using System;
using System.Linq;

namespace _09._Kamino_Factory
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string command = Console.ReadLine();
            int sequenceNum = 0, sequenceLenght = 1, sequenceIndex = 0, sequenceSum = 0, maxSequenceLenght = 0, maxSequenceNum = 0, maxSequenceIndex = 0, maxSequenceSum = 0;
            bool isSequence = true;
            while (command != "Clone them!")
            {
                int[] sequence = command.Split('!')
                    .Select(int.Parse)
                    .ToArray();
                for (int i = 0; i < sequence.Length; i++)
                {
                    int testNum = sequence[i];
                    for (int k = i + 1; k < sequence.Length; k++)
                    {
                        if (!isSequence) break;
                        if (sequence[k] == testNum && isSequence)
                        {
                            sequenceNum = testNum;
                            sequenceIndex = i;
                            sequenceLenght++;
                        }
                        else
                        {
                            isSequence = false;
                        }
                    }
                    sequenceSum = sequenceNum * sequenceLenght;
                    isSequence = true;
                    if (sequenceLenght > maxSequenceLenght)
                    {
                        maxSequenceLenght = sequenceLenght;
                        maxSequenceIndex = sequenceIndex;
                        maxSequenceNum = sequenceNum;
                        maxSequenceSum = maxSequenceSum * maxSequenceLenght;
                    }
                    else if (sequenceLenght == maxSequenceLenght && sequenceIndex < maxSequenceIndex)
                    {
                        maxSequenceLenght = sequenceLenght;
                        maxSequenceIndex = sequenceIndex;
                        maxSequenceNum = sequenceNum;
                        maxSequenceSum = maxSequenceSum * maxSequenceLenght;
                    }
                    else if (sequenceLenght == maxSequenceLenght && sequenceIndex == maxSequenceIndex && sequenceSum > maxSequenceSum)
                    {
                        maxSequenceLenght = sequenceLenght;
                        maxSequenceIndex = sequenceIndex;
                        maxSequenceNum = sequenceNum;
                        maxSequenceSum = maxSequenceSum * maxSequenceLenght;
                    }
                    sequenceLenght = 1;
                }
            }
            Console.WriteLine( $"Best DNA sample {maxSequenceIndex} with sum: { maxSequenceSum}.");
            //for (int i = 0; i >)
        }
        //static int MaxSequenceSetting(int sequenceLenght,int sequenceIndex,int sequenceNum)
        //{
        //    return;
        //}
    }
}
