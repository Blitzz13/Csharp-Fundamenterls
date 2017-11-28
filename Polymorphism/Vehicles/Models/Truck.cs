namespace Vehicles
{
	public class Truck : Vehicle
	{
		private const double AcConsumption = 1.6;
		private const double FuelLossFactor = 0.95;

		public Truck(double fuelQuantity, double fuelConsumption, double tankCapacity) 
			: base(fuelQuantity, fuelConsumption + AcConsumption, tankCapacity)
		{
		}

		public override void Refuel(double fuelAmount)
		{
			base.Refuel(fuelAmount * FuelLossFactor);
		}
	}
}
