using System;

namespace _04._Raw_Data
{
    class Engine
    {
        public Engine(int engineSpeed, int enginePower)
        {
            this.EngineSpeed = engineSpeed;
            this.EnginePower = enginePower;
        }
        public int EnginePower { get; set; }
        public int EngineSpeed { get; set; }
    }
    class Cargo
    {
        public Cargo(int cargoWeight, string cargoType)
        {
            this.CargoType = cargoType;
            this.CargoWeight = cargoWeight;
        }
        public string CargoType { get; set; }
        public int CargoWeight { get; set; }
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
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
}
