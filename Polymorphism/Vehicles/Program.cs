using System;

namespace Vehicles
{
	public class Program
	{
		static void Main(string[] args)
		{
			string[] carInfo = Console.ReadLine().Split();
			Vehicle car = new Car(double.Parse(carInfo[1]), double.Parse(carInfo[2]), double.Parse(carInfo[3]));

			string[] truckInfo = Console.ReadLine().Split();
			Vehicle truck = new Truck(double.Parse(truckInfo[1]), double.Parse(truckInfo[2]), double.Parse(truckInfo[3]));

			string[] busInfo = Console.ReadLine().Split();
			Vehicle bus = new Bus(double.Parse(busInfo[1]), double.Parse(busInfo[2]), double.Parse(busInfo[3]));

			int commandsNumber = int.Parse(Console.ReadLine());

			for (int i = 0; i < commandsNumber; i++)
			{
				string[] command = Console.ReadLine().Split();
				var vehicleType = command[1];

				try
				{
					if (vehicleType == "Car")
					{
						ExecuteAction(car, command[0], double.Parse(command[2]));
					}
					else if (vehicleType == "Truck")
					{
						ExecuteAction(truck, command[0], double.Parse(command[2]));
					}
					else if (vehicleType == "Bus")
					{
						ExecuteAction(bus, command[0], double.Parse(command[2]));
					}
				}
				catch (ArgumentException argumentException)
				{
					Console.WriteLine(argumentException.Message);
				}
			}
			Console.WriteLine(car);
			Console.WriteLine(truck);
			Console.WriteLine(bus);
		}

		private static void ExecuteAction(Vehicle vehicle, string command, double parameter)
		{
			string result = "";
			switch (command)
			{
				case "Drive":
					result = vehicle.TryTravelDistance(parameter);
					Console.WriteLine(result);
					break;
				case "Refuel":
					vehicle.Refuel(parameter);
					break;
				case "DriveEmpty":
					result = vehicle.TryTravelDistance(parameter, false);
					Console.WriteLine(result);
					break;
			}
		}


	}
}
