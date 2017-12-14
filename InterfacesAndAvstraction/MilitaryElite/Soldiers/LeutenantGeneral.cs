using System;
using System.Collections.Generic;

namespace MilitaryElite
{
	class LeutenantGeneral : ILeutenantGeneral
	{
		private List<Private> _privates;
		public LeutenantGeneral(int id, string firstName, string lastName, double salary)
		{
			Id = id;
			FirstName = firstName;
			LastName = lastName;
			Salary = salary;
		}

		public LeutenantGeneral()
		{
		}

		public int Id { get; }
		public string FirstName { get; }
		public string LastName { get; }
		public double Salary { get; }

		public List<Private> Privates
		{
			get => _privates;
			set => _privates = value;
		}

		private void PrintPrivates()
		{
			foreach (var @private in this.Privates)
			{
				Console.WriteLine($"  {@private}");
			}
		}

		public override string ToString()
		{
			Console.WriteLine($"Name: {FirstName} {LastName} Id: {Id} Salary: {Salary}");
			Console.WriteLine("Privates");
			PrintPrivates();
			return"";
		}
	}
}
