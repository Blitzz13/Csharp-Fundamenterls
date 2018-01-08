using System.Collections.Generic;

namespace StrategyPattern
{
	class AgeCoparer : IComparer<Person>
	{
		public int Compare(Person firstPerson, Person secondPerson)
		{
			return firstPerson.Age - secondPerson.Age;
		}
	}
}
