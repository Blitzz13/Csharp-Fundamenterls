using System;
using System.Collections.Generic;

namespace StrategyPattern
{
	class NameLengthComparer : IComparer<Person>
	{
		public int Compare(Person firstPerson, Person secondPerson)
		{
			if (firstPerson.Name.Length == secondPerson.Name.Length)
			{
				return String.CompareOrdinal(firstPerson.Name.ToLower()[0].ToString(), secondPerson.Name.ToLower()[0].ToString());
			}

			return firstPerson.Name.Length - secondPerson.Name.Length;
		}
	}
}
