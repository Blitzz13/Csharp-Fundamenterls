using System.Collections.Generic;

namespace MilitaryElite.Interfaces
{
	interface ICommando : ISpecialisedSoldier
	{
		List<Mission> Missions { get; }
	}
}
