using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceTypeProgram
{
    // 1. Single Inheritance
    public class Bird
    {
        public string FeatherColor { get; set; }

        public void Fly()
        {
            Console.WriteLine("Bird is flying.");
        }
    }

    public class Parrot : Bird
    {
        public void Speak()
        {
            Console.WriteLine("Parrot can mimic sounds.");
        }
    }

    // 2. Hierarchical Inheritance
    public class Vehicle
    {
        public string FuelType { get; set; }
        public int MaxSpeed { get; set; }

        public void Start()
        {
            Console.WriteLine("Vehicle is starting.");
        }
    }

    public class Car : Vehicle
    {
        public int NumberOfSeats { get; set; }

        public void Drive()
        {
            Console.WriteLine("Car is driving.");
        }
    }

    public class Bike : Vehicle
    {
        public string HandlebarType { get; set; }

        public void Ride()
        {
            Console.WriteLine("Bike is riding.");
        }
    }

    public class Truck : Vehicle
    {
        public int CargoCapacity { get; set; }

        public void Load()
        {
            Console.WriteLine("Truck is loading cargo.");
        }
    }

    // 3. Multilevel Inheritance
    public class ElectronicDevice
    {
        public string PowerSource { get; set; }

        public void TurnOn()
        {
            Console.WriteLine("Electronic device is turning on.");
        }
    }

    public class Computer : ElectronicDevice
    {
        public string ProcessorType { get; set; }

        public void Compute()
        {
            Console.WriteLine("Computer is processing data.");
        }
    }

    public class Laptop : Computer
    {
        public int BatteryLife { get; set; }

        public void PortableUse()
        {
            Console.WriteLine("Laptop can be used portably.");
        }
    }
}
