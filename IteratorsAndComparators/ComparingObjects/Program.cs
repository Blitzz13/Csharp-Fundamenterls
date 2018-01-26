using System;
using System.Collections.Generic;
using System.Linq;

namespace ComparingObjects
{
	class Program
	{
		static void Main()
		{
			string[] line = Console.ReadLine().Split();

			IList<Person> people = new List<Person>();
			while (line[0] != "END")
			{
				var person = new Person(line[0], int.Parse(line[1]), line[2]);
				line = Console.ReadLine().Split();
				people.Add(person);
			}

			int n = int.Parse(Console.ReadLine()) - 1;

			int equalPeopleCount = 0;
			int notEqualPeopleCount = 0;
			Person searchedPerson = people[n];
			people.RemoveAt(n);

			foreach (var thisPerson in people)
			{
				if (thisPerson.CompareTo(searchedPerson) == 0)
				{
					equalPeopleCount++;
				}
				else
				{
					notEqualPeopleCount++;
				}
			}

			if (equalPeopleCount <= 0)
			{
				Console.WriteLine("No matches");
			}
			else
			{
				Console.WriteLine($"{equalPeopleCount} {notEqualPeopleCount} {people.Count + 1}");
			}
		}
	}
}
