using System;

namespace _01._Train
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numberOfWagons = int.Parse(Console.ReadLine());
            int[] peopleInEachWagon = new int[numberOfWagons];
            var sum = 0;
            for(int i = 0; i < peopleInEachWagon.Length; i++)
            {
                peopleInEachWagon[i] = int.Parse(Console.ReadLine());
                sum+=peopleInEachWagon[i];
            }
            Console.WriteLine(String.Join(' ',peopleInEachWagon));
            Console.WriteLine(sum);
        }
    }
}
