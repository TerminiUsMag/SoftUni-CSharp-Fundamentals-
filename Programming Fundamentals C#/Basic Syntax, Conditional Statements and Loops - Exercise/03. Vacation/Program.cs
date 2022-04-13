using System;

namespace _03._Vacation
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // a count of people, which are going on vacation.
            // type of the group(students, business, or regular).
            // the day of the week which the group will stay(friday, saturday, or sunday).


            //             Friday   Saturday  Sunday
            // Students    8.45     9.80      10.46
            // Business    10.90    15.60     16
            // Regular     15       20        22.50


            // For Students, if the group is 30 or more people, you should reduce the total price by 15 %
            // For Business, if the group is 100 or more people, 10 of the people stay for free.
            // For Regular, if the group is between 10 and 20  people(both inclusively), reduce the total price by 5 %


            int numberOfPeople = int.Parse(Console.ReadLine());
            string typeOfGroup = Console.ReadLine();
            string dayOfWeek = Console.ReadLine();
            double discountPrice = 0, discountValue = 0, price = 0;


            if (dayOfWeek == "Friday")
            {
                if (typeOfGroup == "Students") price = numberOfPeople * 8.45;
                if (typeOfGroup == "Business") price = numberOfPeople * 10.90;
                if (typeOfGroup == "Regular") price = numberOfPeople * 15;
            }
            else if (dayOfWeek == "Saturday")
            {
                if (typeOfGroup == "Students") price = numberOfPeople * 9.80;
                if (typeOfGroup == "Business") price = numberOfPeople * 15.60;
                if (typeOfGroup == "Regular") price = numberOfPeople * 20;
            }
            else if (dayOfWeek == "Sunday")
            {
                if (typeOfGroup == "Students") price = numberOfPeople * 10.46;
                if (typeOfGroup == "Business") price = numberOfPeople * 16;
                if (typeOfGroup == "Regular") price = numberOfPeople * 22.50;
            }

            if (typeOfGroup == "Students" && numberOfPeople >= 30)
            {
                discountValue = price * 0.15;
                discountPrice = price - discountValue;
                price = discountPrice;

            }
            else if (typeOfGroup == "Business" && numberOfPeople >= 100)
            {
                discountValue = 10 * (price / numberOfPeople);
                price = price - discountValue;
            }
            else if (typeOfGroup == "Regular" && numberOfPeople >= 10 && numberOfPeople <= 20)
            {
                discountValue = price * 0.05;
                discountPrice = price - discountValue;
                price = discountPrice;
            }
            Console.WriteLine($"Total price: {price:f2}");
        }
    }
}
