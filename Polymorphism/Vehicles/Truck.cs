	using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vehicles
{
	public class Truck : Vehicle
	{
		private const double AcConsumption = 1.6;
		private const double FuelLossFactor = 0.95;

		public Truck(double fuelQuantity, double fuelConsumption) 
			: base(fuelQuantity, fuelConsumption + AcConsumption)
		{
		}

		public override void Refuel(double fuelAmount)
		{
			base.Refuel(fuelAmount * FuelLossFactor);
		}
	}
}
