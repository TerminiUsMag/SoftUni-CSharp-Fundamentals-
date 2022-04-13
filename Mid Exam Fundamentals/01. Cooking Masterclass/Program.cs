using System;

namespace _01._Cooking_Masterclass
{
    internal class Program
    {
        static void Main(string[] args)
        {
            float budget = float.Parse(Console.ReadLine());
            int students = int.Parse(Console.ReadLine());
            float flourPerPackage = float.Parse(Console.ReadLine());
            float eggPrice = float.Parse(Console.ReadLine());
            float apronSinglePrice = float.Parse(Console.ReadLine());

            int packagesOfFlour = students - (students / 5);
            float totalAprons = (float)(students + Math.Ceiling(students * 0.2));
            float totalEggPrice = (students * 10) * eggPrice;
            float totalApronPrice = totalAprons * apronSinglePrice;
            float totalFlourPrice = flourPerPackage * packagesOfFlour;

            float priceTotal = totalEggPrice + totalFlourPrice + totalApronPrice;

            // For Each Student : 1 package of flour, 10 eggs, 1 apron.
            if (budget >= priceTotal)
            {
                Console.WriteLine($"Items purchased for {priceTotal:f2}$.");
            }
            else
            {
                Console.WriteLine($"{priceTotal - budget:f2}$ more needed.");
            }
        }
    }
}
