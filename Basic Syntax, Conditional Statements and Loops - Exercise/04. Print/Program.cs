using System;

namespace _04._Print
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            double sum = 0;

            for(int x = a; x <= b; x++)
            {
                if(x!=b)Console.Write($"{x} ");
                else Console.WriteLine($"{x} ");
                sum += x;
            }
            Console.WriteLine($"Sum: {sum}");
        }
    }
}
