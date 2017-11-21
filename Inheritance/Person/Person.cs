using System;
using System.Text;

namespace Person
{
	public class Person
	{
		public string _name;
		public int _age;

		public Person(string _name, int _age)
		{
			this.Name = _name;
			this.Age = _age;
		}

		public virtual string Name
		{
			get { return _name; }
			set
			{
				if (value.Length < 3)
				{
					throw new ArgumentException("Name's length should not be less than 3 symbols!");
				}
				_name = value;
			}
		}

		public virtual int Age
		{
			get { return _age; }
			set
			{
				if (value < 0)
				{
					throw new ArgumentException("Age must be positive!");
				}

				this._age = value;
			}
		}

		public override string ToString()
		{
			return $"Name: {this.Name}, Age: {this.Age}";
		}

	}
}
