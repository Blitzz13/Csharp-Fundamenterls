using System.Collections.Generic;
using MilitaryElite.Interfaces;

namespace MilitaryElite
{
	class Engineer : IEngineer
	{
		public Engineer(int id, string firstName, string lastName, double salary, string corps)
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
		public List<Repair> Repairs { get; }
	}
}
