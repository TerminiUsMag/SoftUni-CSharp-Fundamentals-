using System;

namespace _07._Water_Overflow
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const int Capacity = 255;
            int n = int.Parse(Console.ReadLine());
            double quantity = 0;

            for (int i = 0; i < n; i++)
            {
                int x = int.Parse(Console.ReadLine());
                if (Capacity < quantity + x)
                {
                    Console.WriteLine("Insufficient capacity!");
                }
                else
                {
                    quantity += x;
                }
            }
            Console.WriteLine(quantity);
        }
    }
}
