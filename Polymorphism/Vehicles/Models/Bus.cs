using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vehicles
{
	public class Bus : Vehicle
	{
		private const double AcConsumption = 1.4;

		public Bus(double fuelQuantity, double fuelConsumption, double tankCapacity)
			: base(fuelQuantity, fuelConsumption, tankCapacity)
		{
		}

		protected override double FuelQuantity
		{
			set
			{
				if (value > this.TankCapacity)
				{
					throw new ArgumentException("Cannot fit fuel in tank");
				}

				base.FuelQuantity = value;
			}

		}

		protected override bool Drive(double distance, bool isAcOn)
		{
			double requiredFuel = 0;
			if (isAcOn)
			{
				requiredFuel = distance * (this.FuelConsuption + AcConsumption);
			}
			else
			{
				requiredFuel = distance * FuelConsuption;
			}

			if (requiredFuel <= this.FuelQuantity)
			{
				this.FuelQuantity -= requiredFuel;
				return true;
			}

			return false;
		}
	}
}
