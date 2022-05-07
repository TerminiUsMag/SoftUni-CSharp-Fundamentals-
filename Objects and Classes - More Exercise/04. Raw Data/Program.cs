using System;
using System.Collections.Generic;
using System.Linq;

namespace _04._Raw_Data
{
    class Engine
    {
        public Engine(int engineSpeed, int enginePower)
        {
            this.Speed = engineSpeed;
            this.Power = enginePower;
        }
        public int Power { get; set; }
        public int Speed { get; set; }
    }
    class Cargo
    {
        public Cargo(int cargoWeight, string cargoType)
        {
            this.Type = cargoType;
            this.Weight = cargoWeight;
        }
        public string Type { get; set; }
        public int Weight { get; set; }
    }
    class Car
    {
        public Car(string model, int engineSpeed, int enginePower, int cargoWeight, string cargoType)
        {
            this.Model = model;
            this.Engine = new Engine(engineSpeed, enginePower);
            this.Cargo = new Cargo(cargoWeight, cargoType);
        }
        public Cargo Cargo { get; set; }
        public Engine Engine { get; set; }
        public string Model { get; set; }
        public bool IsFlamable()
        {
            bool isFlamable = false;
            if (this.Cargo.Type == "flamable" && this.Engine.Power > 250) isFlamable = true;
            return isFlamable;
        }
        public bool IsFragile()
        {
            bool isFragile = false;
            if (this.Cargo.Type == "fragile" && this.Cargo.Weight < 1000) isFragile = true;
            return isFragile;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            var cars = new List<Car>();

            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);
                string model = input[0];
                int engineSpeed = int.Parse(input[1]);
                int enginePower = int.Parse(input[2]);
                int cargoWeight = int.Parse(input[3]);
                string cargoType = input[4];

                var newCar = new Car(model, engineSpeed, enginePower, cargoWeight, cargoType);

                cars.Add(newCar);
            }

            string command = Console.ReadLine();
            switch (command)
            {
                case "fragile":
                    foreach (var car in cars)
                    {
                        if (car.IsFragile())
                        {
                            Console.WriteLine($"{car.Model}");
                        }
                    }
                    break;
                case "flamable":
                    foreach (var car in cars)
                    {
                        if (car.IsFlamable())
                        {
                            Console.WriteLine($"{car.Model}");
                        }
                    }
                    break;
            }
        }
    }
}
