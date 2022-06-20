using System;
namespace FactoryPattern
{
	public class Car : IVehicle
	{
		public Car()
        {
            Console.WriteLine("New Car");
        }

        public void Drive()
        {
            Console.WriteLine("Building new car");
        }
    }
}

