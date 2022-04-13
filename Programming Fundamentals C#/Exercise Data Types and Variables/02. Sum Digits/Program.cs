using System;

namespace _02._Sum_Digits
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int sum = 0;

            while (n > 0)
            {
                int r;
                r = n % 10;
                n = n / 10;
                sum += r;
            }
            Console.WriteLine(sum);
        }
    }
}
