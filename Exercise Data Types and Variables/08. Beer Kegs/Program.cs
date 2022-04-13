using System;

namespace _08._Beer_Kegs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string maxModel = "";
            double maxVolume = 0;
            for (int i = 0; i < n; i++)
            {
                string currModel = Console.ReadLine();
                double currRadius = double.Parse(Console.ReadLine());
                int currHeight = int.Parse(Console.ReadLine());
                double currVolume = Math.PI * (currRadius * currRadius) * currHeight;
                if (currVolume > maxVolume)
                {
                    maxVolume = currVolume;
                    maxModel = currModel;
                }
            }
            Console.WriteLine(maxModel);
        }
    }
}
