using System;
using System.Collections.Generic;
using System.Linq;

namespace _03._Speed_Racing
{
    class Car
    {
        public Car(string model, double fuelAmount, double fuelConsumptionPerKilometer)
        {
            this.Model = model;
            this.FuelAmount = fuelAmount;
            this.FuelConsumptionPerKilometer = fuelConsumptionPerKilometer;
            this.TraveledDistance = 0;
        }
        public double TraveledDistance { get; set; }
        public double FuelConsumptionPerKilometer { get; set; }
        public double FuelAmount { get; set; }
        public string Model { get; set; }
        public void Drive(double amountOfKm)
        {
            var neededFuel = FuelConsumptionPerKilometer * amountOfKm;

            if (amountOfKm <= 0) { return; }
            if (neededFuel > FuelAmount)
            {
                Console.WriteLine("Insufficient fuel for the drive");
            }
            if (neededFuel <= FuelAmount)
            {
                FuelAmount -= neededFuel;
                TraveledDistance += amountOfKm;
            }
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
                double fuelAmount = double.Parse(input[1]);
                double fuelConsumptionPerKilometer = double.Parse(input[2]);

                var newCar = new Car(model, fuelAmount, fuelConsumptionPerKilometer);

                cars.Add(newCar);
            }

            string command;
            while ((command = Console.ReadLine()) != "End")
            {
                string[] input = command.Split(' ', StringSplitOptions.RemoveEmptyEntries);
                string drive = input[0];
                string model = input[1];
                double amountOfKm = double.Parse(input[2]);

                var carToDrive = cars.Where(x => x.Model == model).FirstOrDefault();
                carToDrive.Drive(amountOfKm);

            }
            //"<Model> <fuelAmount> <distanceTraveled>"
            foreach (var car in cars)
            {
                Console.WriteLine($"{car.Model} {car.FuelAmount:f2} {car.TraveledDistance}");
            }
        }
    }
}
