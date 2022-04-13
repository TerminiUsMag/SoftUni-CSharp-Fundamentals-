using System;

namespace _02._From_Left_to_The_Right___More_Exercise
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string right = "";
            string left = "";
            long intLeft, intRight;
            long sum = 0;

            for (int i = 0; i < n; i++)
            {
                string nums = Console.ReadLine();
                for (int j = 0; j < nums.Length; j++)
                {
                    if (nums[j].Equals(' '))
                    {
                        for (int x = j + 1; x < nums.Length; x++)
                        {
                            right += nums[x];
                        }
                        for (int x = 0; x < j; x++)
                        {
                            left += nums[x];
                        }
                    }
                }
                intLeft = long.Parse(left);
                intRight = long.Parse(right);
                left = "";
                right = "";
                if (intLeft > intRight)
                {
                    while (intLeft != 0)
                    {
                        sum += intLeft % 10;
                        intLeft /= 10;
                    }
                }
                else
                {
                    while (intRight != 0)
                    {
                        sum += intRight % 10;
                        intRight /= 10;
                    }
                }
                Console.WriteLine(Math.Abs(sum));
                sum = 0;
            }
        }
    }
}
