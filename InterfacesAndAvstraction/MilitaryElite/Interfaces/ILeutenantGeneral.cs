using System.Collections.Generic;

namespace MilitaryElite
{
	interface ILeutenantGeneral : IPrivate
	{
		List<Private> Privates { get; }
	}
}
