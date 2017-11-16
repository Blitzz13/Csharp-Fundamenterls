using System;
using System.Collections.Generic;
using System.Linq;

namespace PizzaCalories
{
	class Pizza
	{
		private string _name;
		private Dough _dough;
		private List<Topping> _toppings;
		private int _numberOfToppings;

		public Pizza(string _name, int _numberOfTopping)
		{
			this.Name = _name;
			this._toppings = new List<Topping>();
			this.NumberOfToppings = _numberOfTopping;
		}

		public Dough Dough
		{
			set { this._dough = value; }
		}
		public int NumberOfToppings
		{
			get { return this._numberOfToppings; }
			set
			{
				if (value < 0 || value > 10)
				{
					throw new ArgumentException("Number of toppings should be in range [0..10].");
				}
				this._numberOfToppings = value;
			}
		}

		public string Name
		{
			get { return this._name; }
			set
			{
				if (value.Length < 1 || value.Length > 15)
				{
					throw new ArgumentOutOfRangeException("Pizza name should be between 1 and 15 symbols.");
				}
				this._name = value;
			}
		}

		public void AddTopping(Topping topping)
		{
			this._toppings.Add(topping);
		}

		public double getCalories()
		{
			return this._dough.GetCalories() + this._toppings.Sum(t => t.GetCalories());
		}
	}
}
