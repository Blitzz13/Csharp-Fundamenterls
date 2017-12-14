using System.Collections.Generic;

namespace MilitaryElite
{
	interface ISpecialisedSoldier : IPrivate
	{
		string Corps { get; }
	}
}
