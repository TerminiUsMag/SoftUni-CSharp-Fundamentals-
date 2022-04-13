using System;

namespace _01._Integer_Operations
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int operation1, operation2, operation3;
            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());
            int num3 = int.Parse(Console.ReadLine());
            int num4 = int.Parse(Console.ReadLine());

            operation1 = num1 + num2;
            operation2 = operation1 / num3;
            operation3 = operation2 * num4;
            Console.WriteLine(operation3);

        }
    }
}
