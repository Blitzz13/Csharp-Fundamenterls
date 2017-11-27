using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vehicles
{
	public class Program
	{
		static void Main(string[] args)
		{
			string[] carInfo = Console.ReadLine().Split();
			Vehicle car = new Car(double.Parse(carInfo[1]), double.Parse(carInfo[2]));

			string[] truckInfo = Console.ReadLine().Split();
			Vehicle truck = new Truck(double.Parse(truckInfo[1]), double.Parse(truckInfo[2]));
			int commandsNumber = int.Parse(Console.ReadLine());

			for (int i = 0; i < commandsNumber; i++)
			{
				string[] command = Console.ReadLine().Split();
				var vehicleType = command[1];

				if (vehicleType == "Car")
				{
					ExecuteAction(car, command[0], double.Parse(command[2]));
				}
				else
				{
					ExecuteAction(truck, command[0], double.Parse(command[2]));
				}
			}
			Console.WriteLine(car);
			Console.WriteLine(truck);
		}

		private static void ExecuteAction(Vehicle vehicle, string command, double parameter)
		{
			switch (command)
			{
				case "Drive":
					string result = vehicle.TryTravelDistance(parameter);
					Console.WriteLine(result);
					break;
				case "Refuel":
					vehicle.Refuel(parameter);
					break;
			}
		}

		
	}
}
