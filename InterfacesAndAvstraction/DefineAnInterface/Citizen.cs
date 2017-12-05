﻿namespace DefineAnInterface
{
	class Citizen : IPerson
	{
		public Citizen(string name, int age)
		{
			this.Name = name;
			this.Age = age;
		}

		public string Name { get; set; }
		public int Age { get; set; }
	}
}
