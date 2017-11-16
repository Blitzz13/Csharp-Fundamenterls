using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaCalories
{
	class Topping
	{
		private string _type;
		private double _weight;

		private const int MinWeight = 1;
		private const int MaxWeight = 50;

		public Topping(string _type, double _weight)
		{
			Type = _type;
			Weight = _weight;
		}

		public double Weight
		{
			get { return _weight; }
			set
			{
				if (value < MinWeight || value > MaxWeight)
				{
					throw new ArgumentException($"{this.Type} weight should be in the range [{MinWeight}..{MaxWeight}].");
				}
				_weight = value;
			}
		}


		public string Type
		{
			get { return _type; }
			set
			{
				if (value.ToLower() != "meat" && value.ToLower() != "veggies"
					&& value.ToLower() != "sauce" && value.ToLower() != "cheese")
				{
					throw new ArgumentException($"Cannot place {value} on top of your pizza.");
				}
				_type = value;
			}
		}

		public double GetCalories()
		{
			return 2 * Weight * this.GetTypeMod();
		}

		public double GetTypeMod()
		{
			if (this.Type.ToLower() == "meat")
			{
				return 1.2;
			}
			else if (this.Type.ToLower() == "veggies")
			{
				return 0.8;
			}
			else if (this.Type.ToLower() == "cheese")
			{
				return 1.1;
			}

			return 0.9;
		}
	}
}
