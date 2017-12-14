using System;
using MilitaryElite.Interfaces;

namespace MilitaryElite
{
	class Spy : ISpy
	{
		public Spy(int id, string firstName, string lastName, double salary,int codeNumber)
		{
			Id = id;
			FirstName = firstName;
			LastName = lastName;
			Salary = salary;
			CodeNumber = codeNumber;
		}

		public int Id { get; }
		public string FirstName { get; }
		public string LastName { get; }
		public double Salary { get; }
		public int CodeNumber { get; set; }

		public override string ToString()
		{
			return $"Name: {FirstName} {LastName} Id: {Id}{Environment.NewLine}" +
			       $"Code Number: {CodeNumber}";
		}
	}
}
