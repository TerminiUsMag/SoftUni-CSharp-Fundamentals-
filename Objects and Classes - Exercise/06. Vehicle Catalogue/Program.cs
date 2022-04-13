using System;
using System.Collections.Generic;
using System.Linq;

namespace _06._Vehicle_Catalogue
{
    class Vehicle
    {
        public Vehicle(string type, string model, string color, int horsePower)
        {
            this.Type = type;
            this.Model = model;
            this.Color = color;
            this.HorsePower = horsePower;
        }
        public string Type { get; set; }
        public string Model { get; set; }
        public string Color { get; set; }
        public int HorsePower { get; set; }

    }
    internal class Program
    {
        static void Main(string[] args)
        {
            string command;

            List<Vehicle> vehicleCatalogue = new List<Vehicle>();

            while ((command = Console.ReadLine()) != "End")
            {
                string[] argsAddVechicle = command.Split(' ', StringSplitOptions.RemoveEmptyEntries);

                string typeOfVehicle = argsAddVechicle[0];
                string model = argsAddVechicle[1];
                string color = argsAddVechicle[2];
                int horsePower = int.Parse(argsAddVechicle[3]);
                if (typeOfVehicle == "car") typeOfVehicle = "Car";
                if (typeOfVehicle == "truck") typeOfVehicle = "Truck";

                Vehicle newVehicle = new Vehicle(typeOfVehicle, model, color, horsePower);
                vehicleCatalogue.Add(newVehicle);
            }

            while ((command = Console.ReadLine()) != "Close the Catalogue")
            {
                Vehicle currentVehicle = vehicleCatalogue
                    .FirstOrDefault(v => v.Model == command);
                //"Type: {typeOfVehicle}
                //Model: { modelOfVehicle}
                //Color: { colorOfVehicle}
                //Horsepower: { horsepowerOfVehicle}"
                Console.WriteLine($"Type: {currentVehicle.Type}\nModel: {currentVehicle.Model}\nColor: {currentVehicle.Color}\nHorsepower: {currentVehicle.HorsePower}");
            }
            double carsAverageHorsepower = 0, trucksAverageHorsepower = 0;
            int carsCount = 0, trucksCount = 0;
            foreach (var vehicle in vehicleCatalogue)
            {
                if (vehicle.Type == "Car")
                {
                    carsAverageHorsepower += vehicle.HorsePower;
                    carsCount++;
                }
                else if (vehicle.Type == "Truck")
                {
                    trucksAverageHorsepower += vehicle.HorsePower;
                    trucksCount++;
                }
            }
            if (carsCount > 0)
            {
                carsAverageHorsepower = carsAverageHorsepower / carsCount;
            }
            if (trucksCount > 0)
            {
                trucksAverageHorsepower /= trucksCount;
            }

            Console.WriteLine($"Cars have average horsepower of: {carsAverageHorsepower:f2}.");
            Console.WriteLine($"Trucks have average horsepower of: {trucksAverageHorsepower:f2}.");
        }
    }
}
