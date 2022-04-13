using System;
using System.Collections.Generic;
using System.Linq;

namespace _07._Vehicle_Catalogue
{
    //Define a class Truck with the following properties: Brand, Model, and Weight.
    //Define a class Car with the following properties: Brand, Model, and Horse Power.
    //Define a class Catalog with the following properties: Collections of Trucks and Cars.

    class Catalog
    {
        public Catalog(List<Car> cars, List<Truck> trucks)
        {
            this.Cars = cars;
            this.Trucks = trucks;
        }
        public List<Car> Cars { get; set; }
        public List<Truck> Trucks { get; set; }
        public void Print()
        {
            Console.WriteLine("Cars: ");
            foreach (Car car in Cars)
            {
                Console.WriteLine($"{car.Brand}: {car.Model} - {car.HorsePower}hp");
            }
            Console.WriteLine("Trucks: ");
            foreach (Truck truck in Trucks)
            {
                Console.WriteLine($"{truck.Brand}: {truck.Model} - {truck.Weight}kg");
            }
        }
    }
    class Car
    {
        public Car(string brand, string model, double horsePower)
        {
            this.Brand = brand;
            this.Model = model;
            this.HorsePower = horsePower;
        }
        public double HorsePower { get; set; }
        public string Model { get; set; }
        public string Brand { get; set; }
    }
    class Truck
    {
        public Truck(string brand, string model, double weight)
        {
            this.Brand = brand;
            this.Model = model;
            this.Weight = weight;
        }

        public double Weight { get; set; }
        public string Model { get; set; }
        public string Brand { get; set; }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            string command = Console.ReadLine();

            List<Car> cars = new List<Car>();
            List<Truck> trucks = new List<Truck>();
            //Catalog catalog = new Catalog(cars,trucks);

            while (command != "end")
            {
                string[] tokens = command.Split('/', StringSplitOptions.RemoveEmptyEntries);

                if (tokens[0] == "Car")
                {
                    string brand = tokens[1];
                    string model = tokens[2];
                    double horsePower = double.Parse(tokens[3]);

                    Car newCar = new Car(brand, model, horsePower);

                    cars.Add(newCar);
                }

                else if (tokens[0] == "Truck")
                {
                    string brand = tokens[1];
                    string model = tokens[2];
                    double weight = double.Parse(tokens[3]);

                    Truck newTruck = new Truck(brand, model, weight);

                    trucks.Add(newTruck);
                }

                command = Console.ReadLine();
            }

            List<Car> sortedCars = cars.OrderBy(x => x.Brand).ToList();
            List<Truck> sortedTrucks = trucks.OrderBy(x => x.Brand).ToList();

            Catalog result = new Catalog(sortedCars, sortedTrucks);
            result.Print();
        }
    }
}
