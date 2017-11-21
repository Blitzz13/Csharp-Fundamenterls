using System;

namespace Person
{
	public class Child:Person
	{

		public Child(string _name,int _age)
			:base(_name,_age)
		{
			
		}

		public override int Age
		{
			get { return base.Age; }
			set
			{
				if (value > 15)
				{
					throw new ArgumentException("Child\'s age must be less than 15!");
				}
				base.Age = value;
			}
		}
	}
}
