using System;
namespace FactoryPattern
{
	public static class VehicleFactory
	{
		public static IVehicle GetVehicle(string wheels)
        {
			 switch (wheels)
            {
				case "4":
					return new Car();
				case "2":
					return new Motorcycle();
				default:
					return new Motorcycle();

            }
        }
	}
}

