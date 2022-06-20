using System;

namespace FactoryPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter number of wheels your vehicle will have?");
            var wheels = Console.ReadLine();
            IVehicle vehicle = VehicleFactory.GetVehicle(wheels);

            vehicle.Drive();
        }
    }
}

