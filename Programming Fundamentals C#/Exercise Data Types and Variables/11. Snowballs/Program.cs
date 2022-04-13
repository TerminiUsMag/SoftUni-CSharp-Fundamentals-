using System;
using System.Numerics;

namespace _11._Snowballs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //You will receive N – an integer, the number of snowballs being made by Tony and Andi.
            //For each snowball you will receive 3 input lines:
            //⦁	On the first line, you will get the snowballSnow – an integer.
            //⦁	On the second line, you will get the snowballTime – an integer.
            //⦁	On the third line, you will get the snowballQuality – an integer.
            //For each snowball you must calculate its snowballValue by the following formula:
            //(snowballSnow / snowballTime) ^ snowballQuality
            //In the end, you must print the highest calculated snowballValue.

            int n = int.Parse(Console.ReadLine());
            int highestSnow = 0, highestTime = 0, highestQuality = 0;
            BigInteger highestValue = 0;
            for (int i = 0; i < n; i++)
            {
                int snowballSnow = int.Parse(Console.ReadLine());
                int snowballTime = int.Parse(Console.ReadLine());
                int snowballQuality = int.Parse(Console.ReadLine());
                BigInteger snowballValue = BigInteger.Pow((snowballSnow / snowballTime), snowballQuality);
                if (snowballValue > highestValue)
                {
                    highestValue = snowballValue;
                    highestTime = snowballTime;
                    highestSnow = snowballSnow;
                    highestQuality = snowballQuality;
                }
            }
            Console.WriteLine($"{ highestSnow} : { highestTime} = { highestValue} ({ highestQuality})");
        }
    }
}
