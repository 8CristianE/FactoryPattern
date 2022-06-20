using System;
namespace FactoryPattern
{
	public class Motorcycle : IVehicle
	{
		public Motorcycle()
		{
            Console.WriteLine("New Motorcycle");
		}

        public void Drive()
        {
            Console.WriteLine("Building new motorcycle");
        }
    }
}

