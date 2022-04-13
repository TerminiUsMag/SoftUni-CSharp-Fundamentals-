using System;
using System.Collections.Generic;
using System.Linq;

namespace _06._Store_Boxes
{
    class Item
    {
        public double Price { get; set; }
        public string Name { get; set; }
    }
    class Box
    {
        public Box()
        {
            Item = new Item();
        }
        public double PriceForABox { get; set; }
        public int ItemQuantity { get; set; }
        public Item Item { get; set; }
        public string SerialNumber { get; set; }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            string command = Console.ReadLine();
            List<Box> boxes = new List<Box>();

            while (command != "end")
            {

                string[] tokens = command.Split(' ', StringSplitOptions.RemoveEmptyEntries);

                Box box = new Box();
                box.SerialNumber = tokens[0];
                box.Item.Name = tokens[1];
                box.ItemQuantity = int.Parse(tokens[2]);
                box.Item.Price = double.Parse(tokens[3]);
                box.PriceForABox = box.Item.Price * box.ItemQuantity;

                boxes.Add(box);

                command = Console.ReadLine();
            }
            List<Box> sortedBoxes = boxes.OrderByDescending(x => x.PriceForABox).ToList();

            foreach(Box box in sortedBoxes)
            {
                Console.WriteLine($"{box.SerialNumber}");
                Console.WriteLine($"-- {box.Item.Name} - ${box.Item.Price:f2}: {box.ItemQuantity}");
                Console.WriteLine($"-- ${box.PriceForABox:f2}");
            }


        }
    }
}
