using System;

namespace _09._Padaw
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double money = double.Parse(Console.ReadLine());
            int numberOfStudents = int.Parse(Console.ReadLine());
            double priceOfSaber = double.Parse(Console.ReadLine());
            double priceOfRobes = double.Parse(Console.ReadLine());
            double priceOfBelts = double.Parse(Console.ReadLine());
            int numberOfSabers = (int)Math.Ceiling(numberOfStudents + (numberOfStudents * 0.1));
            int freeBelts = numberOfStudents / 6;

            double priceOfEquipment = numberOfSabers * priceOfSaber + priceOfRobes * numberOfStudents + priceOfBelts * (numberOfStudents - freeBelts);

            if(money >= priceOfEquipment)
            {
                Console.WriteLine($"The money is enough - it would cost {priceOfEquipment:f2}lv.");
            }
            else
            {
                Console.WriteLine($" John will need {priceOfEquipment-money:f2}lv more.");
            }

        }
    }
}
