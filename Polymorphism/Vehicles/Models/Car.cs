using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vehicles
{
	class Car : Vehicle
	{
		private const double AcConsumption = 0.9;
		public Car(double fuelQuantity, double fuelConsumption, double tankCapacity) 
			: base(fuelQuantity, fuelConsumption + AcConsumption, tankCapacity)
		{
		}

		protected override double FuelQuantity
		{
			set
			{
				if (value > this.TankCapacity)
				{
					throw new ArgumentException("Cannot fit in tank");
				}

				base.FuelQuantity = value;
			}

		}
	}
}
