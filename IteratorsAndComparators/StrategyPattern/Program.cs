using System;
using System.Collections.Generic;
using System.Linq;

namespace StrategyPattern
{
	class Program
	{
		static void Main(string[] args)
		{
			SortedSet<Person> nameComparer = new SortedSet<Person>(new NameLengthComparer());
			SortedSet<Person> ageComparer = new SortedSet<Person>(new AgeCoparer());

			int n = int.Parse(Console.ReadLine());
			for (int i = 0; i < n; i++)
			{
				string[] tokens = Console.ReadLine().Split().ToArray();
				Person person = new Person
				{
					Name = tokens[0],
					Age = int.Parse(tokens[1])
				};
				nameComparer.Add(person);
				ageComparer.Add(person);
			}

			foreach (var person in nameComparer)
			{
				Console.WriteLine($"{person.Name} {person.Age}");
			}

			foreach (var person in ageComparer)
			{
				Console.WriteLine($"{person.Name} {person.Age}");
			}
		}
	}
}
