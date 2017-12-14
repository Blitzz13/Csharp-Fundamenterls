using System.Collections.Generic;

namespace MilitaryElite
{
	class SpecialisedSoldier : ISpecialisedSoldier
	{
		public int Id { get; }
		public string FirstName { get; }
		public string LastName { get; }
		public double Salary { get; }
		public string Corps { get; }
		public List<Private> Privates { get; }
	}
}
