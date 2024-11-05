using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceTypeProgram
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // Single Inheritance
            Parrot parrot = new Parrot();
            parrot.FeatherColor = "Green";
            parrot.Fly();
            parrot.Speak();

            // Hierarchical Inheritance
            Car car = new Car();
            car.FuelType = "Petrol";
            car.NumberOfSeats = 4;
            car.Start();
            car.Drive();

            Bike bike = new Bike();
            bike.FuelType = "Electric";
            bike.HandlebarType = "Standard";
            bike.Start();
            bike.Ride();

            Truck truck = new Truck();
            truck.FuelType = "Diesel";
            truck.CargoCapacity = 5000;
            truck.Start();
            truck.Load();

            // Multilevel Inheritance
            Laptop laptop = new Laptop();
            laptop.PowerSource = "Battery";
            laptop.ProcessorType = "Intel";
            laptop.BatteryLife = 8;
            laptop.TurnOn();
            laptop.Compute();
            laptop.PortableUse();

            Console.ReadLine();
        }
    }
}
