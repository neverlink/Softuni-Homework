using System;
using System.Collections.Generic;
using System.Linq;

namespace P_06._Vehicle_Catalogue
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Vehicle> vehicles = new List<Vehicle>();

            string input = Console.ReadLine();
            while (input != "End")
            {
                string[] vehicleParams = input.Split(' ',
                    StringSplitOptions.RemoveEmptyEntries);

                vehicles.Add(new Vehicle(
                    vehicleParams[0],
                    vehicleParams[1],
                    vehicleParams[2],
                    int.Parse(vehicleParams[3])));

                input = Console.ReadLine();
            }

            input = Console.ReadLine();
            while (input != "Close the Catalogue")
            {
                var currVehicle = vehicles.FirstOrDefault(v => v.Model == input);

                Console.WriteLine($"Type: {char.ToUpper(currVehicle.Type[0])}{currVehicle.Type[1..]}");
                Console.WriteLine($"Model: {currVehicle.Model}");
                Console.WriteLine($"Color: {currVehicle.Color}");
                Console.WriteLine($"Horsepower: {currVehicle.Horsepower}");
                input = Console.ReadLine();
            }

            double avgHpCars = 0.00;
            List<Vehicle> cars = vehicles.Where(v => v.Type == "car").ToList();

            if (cars.Count > 0)
            {
                avgHpCars = cars.Select(v => (double)v.Horsepower).Sum() / cars.Count;
            }
            Console.WriteLine($"Cars have average horsepower of: {avgHpCars:F2}.");

            double avgHpTrucks = 0.00;
            List<Vehicle> trucks = vehicles.Where(v => v.Type == "truck").ToList();

            if (trucks.Count > 0)
            {
                avgHpTrucks = trucks.Select(v => (double)v.Horsepower).Sum() / trucks.Count;
            }
            Console.WriteLine($"Trucks have average horsepower of: {avgHpTrucks:F2}.");
        }
    }

    class Vehicle
    {
        public string Type { get; set; }

        public string Model { get; set; }

        public string Color { get; set; }

        public int Horsepower { get; set; }

        public Vehicle(string type, string model, string color, int horsepower)
        {
            this.Type = type;
            this.Model = model;
            this.Color = color;
            this.Horsepower = horsepower;
        }
    }
}
