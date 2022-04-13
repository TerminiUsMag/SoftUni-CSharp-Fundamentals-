using System;

namespace _00.Demos
{
    public class Cat
    {
        public Cat()
        {
            //Constructor - is called every time a new instance of the class is created without parameters!
            Console.WriteLine("New Cat was created !");
        }

        public Cat(string name, int age, double weight)
        {
            //Constructor with parameters - is called every time a new instance of the class is created with those parameters!
            this.Name = name;
            this.Age = age;
            this.Weight = weight;
        }
        //prop + Tab + Tab - shortcut for property creation :)
        //ctor + Tab + Tab - shortcut for Constructor creation :)

        public string Name { get; set; }

        public int Age { get; set; }

        public double Weight { get; set; }

        public void NotAngry()
        {
            Console.WriteLine("Meow!");
            Console.WriteLine("Puuur");
        }
        public void Info()
        {
            Console.WriteLine($"\nName : {this.Name} \nAge : {this.Age} \nWeight : {this.Weight}\n");
        }

        public void Angry()
        {
            Console.WriteLine("Meeeeeoowwwww!!!!");
            Console.WriteLine("Hissssssss");
            Console.WriteLine("Meowwwwww!!!");
        }

        public void SayName()
        {
            Console.WriteLine($"\nMy name is : {this.Name}\n");
        }
        public bool IsOverWeight()
        {
            if (this.Weight > 7)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("First Cat : ");

            Cat firstCat = new Cat();

            firstCat.Name = "Mei";
            firstCat.Age = 4;
            firstCat.Weight = 6.7;
            firstCat.NotAngry();

            firstCat.Info();
            firstCat.SayName();
            if (firstCat.IsOverWeight())
            {
                Console.WriteLine($"\n{firstCat.Name} is Over Weight !\n");
            }
            else
            {
                Console.WriteLine($"\n{firstCat.Name} isn't Over Weight !\n");
            }
            Console.WriteLine("Second Cat : \n");

            Cat secondCat = new Cat()
            {
                Name = "Kapina",
                Age = 9,
                Weight = 8.4
            };
            secondCat.Angry();

            if (secondCat.IsOverWeight())
            {
                Console.WriteLine($"\n{secondCat.Name} is Over Weight !\n");
            }
            else
            {
                Console.WriteLine($"\n{secondCat.Name} isn't Over Weight !\n");
            }

            secondCat.Info();
            secondCat.SayName();

            Cat thirdCat = new Cat("Pepi", 7, 6.3);
            thirdCat.Info();

        }
    }
}
