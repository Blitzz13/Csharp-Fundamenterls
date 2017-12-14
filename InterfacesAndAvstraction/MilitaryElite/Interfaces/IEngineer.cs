using System.Collections.Generic;

namespace MilitaryElite.Interfaces
{
	interface IEngineer : ISpecialisedSoldier
	{
		List<Repair> Repairs { get; }
	}
}
