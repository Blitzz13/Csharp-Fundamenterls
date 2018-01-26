using System;
using System.Collections.Generic;
using System.Linq;

namespace ComparingObjects
{
	class Person : IComparable<Person>
	{
		private string _name;
		private int _age;
		private string _town;

		public Person(string name, int age, string town)
		{
			this.Name = name;
			this.Age = age;
			this.Town = town;
		}

		public string Name
		{
			get { return _name; }
			set { _name = value; }
		}

		public int Age
		{
			get { return _age; }
			set { _age = value; }
		}

		public string Town
		{
			get { return _town; }
			set { _town = value; }
		}

		public int CompareTo(Person otherPerson)
		{
			if (this.Name != otherPerson.Name)
			{
				return this.Name.CompareTo(otherPerson.Name);
			}

			if (this.Age != otherPerson.Age)
			{
				return this.Age - otherPerson.Age;
			}

			if (this.Town != otherPerson.Town)
			{
				return this.Town.CompareTo(otherPerson._town);
			}

			return 0;
		}
	}
}
