using System;
using System.Collections.Generic;
using MilitaryElite.Interfaces;

namespace MilitaryElite
{
	class Commando : ICommando
	{
		private List<Mission> _missions;
		public Commando(int id, string firstName, string lastName, double salary, string corps)
		{
			Id = id;
			FirstName = firstName;
			LastName = lastName;
			Salary = salary;
			Corps = corps;
		}

		public int Id { get; }
		public string FirstName { get; }
		public string LastName { get; }
		public double Salary { get; }
		public string Corps { get; }
		public List<Mission> Missions
		{
			get => _missions;
			set => _missions = value;
		}

		public override string ToString()
		{
			Console.WriteLine($"Name: {FirstName} {LastName} Id: {Id} Salary: {Salary}");
			Console.WriteLine($"Corps: {Corps}");
			Console.WriteLine("Missions:");
			PrintMissions();
			return "";
		}

		private void PrintMissions()
		{
			if (Missions.Count > 0)
			{
				foreach (var mission in Missions)
				{
					Console.WriteLine($"Code Name: {mission.CodeName} State: {mission.State}");
				}
			}
		}
	}

}
