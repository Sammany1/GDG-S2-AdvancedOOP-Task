using System;

namespace VehicleManagement
{
    // Interface declaration for vehicle actions
    public interface IVehicleActions
    {
        void Honk();
    }

    // Abstract class with static, const, and readonly usage
    public abstract class Vehicle
    {
        // Constant field (compile-time constant)
        public const double DEFAULT_TAX_RATE = 0.15;

        // Static member to keep track of how many vehicles have been created
        public static int VehicleCount { get; private set; } = 0;

        // Readonly field, set only in the constructor
        public readonly DateTime ManufactureDate;

        public Vehicle()
        {
            ManufactureDate = DateTime.Now;
            VehicleCount++;
        }

        // Abstract method to drive the vehicle, to be overridden by derived classes
        public abstract void Drive();

        // Static utility method to print the vehicle count
        public static void PrintVehicleCount()
        {
            Console.WriteLine($"Total Vehicles Created: {VehicleCount}");
        }
    }

    // Concrete class: Car
    public class Car : Vehicle, IVehicleActions
    {
        public double EngineSize { get; set; }

        public Car(double engineSize) : base()
        {
            EngineSize = engineSize;
        }

        public override void Drive()
        {
            Console.WriteLine("Car is driving swiftly on the highway.");
        }

        public void Honk()
        {
            Console.WriteLine("Car honks: Beep beep!");
        }
    }

    // Concrete class: Truck
    public class Truck : Vehicle, IVehicleActions
    {
        public double LoadCapacity { get; set; }

        public Truck(double loadCapacity) : base()
        {
            LoadCapacity = loadCapacity;
        }

        public override void Drive()
        {
            Console.WriteLine("Truck is driving steadily on the road.");
        }

        public void Honk()
        {
            Console.WriteLine("Truck honks: HONK HONK!");
        }
    }

    // Main program to test the classes
    class Program
    {
        static void Main(string[] args)
        {
            Car car1 = new Car(2.0);
            Truck truck1 = new Truck(5000);

            car1.Drive();
            car1.Honk();

            truck1.Drive();
            truck1.Honk();

            // Use the static method to print vehicle count
            Vehicle.PrintVehicleCount();

            // Example usage of the const field for tax calculation
            double carPrice = 25000;
            double tax = carPrice * Vehicle.DEFAULT_TAX_RATE;
            Console.WriteLine($"Tax on the car: {tax:C}");
        }
    }
}
