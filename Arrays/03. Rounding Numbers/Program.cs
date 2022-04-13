using System;

namespace _03._Rounding_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string rawInput = Console.ReadLine();
            string[] stringArray = rawInput.Split();
            double[] numbers = new double[stringArray.Length];

            for(int i = 0; i < stringArray.Length; i++)
            {
                numbers[i] = double.Parse(stringArray[i]);
                if (numbers[i] == -0||numbers[i]==-0.0||numbers[i]==-0.00)
                {
                    numbers[i] = 0;
                }
            }
            
            for(int x =0; x < numbers.Length; x++)
            {
                Console.WriteLine($"{numbers[x]} => {Math.Round(numbers[x],MidpointRounding.AwayFromZero)}");
            }
        }
    }
}
