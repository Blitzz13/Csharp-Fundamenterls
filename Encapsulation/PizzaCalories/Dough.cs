using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaCalories
{
	class Dough
	{
		private string _flourType;
		private string _backingTechnique;
		private double _weight;

		private const int MinWeight = 1;
		private const int MaxWeight = 200;

		public Dough(string _flourType, string _backingTechnique, double _weight)
		{
			this.FlourType = _flourType;
			this.BackingTechnique = _backingTechnique;
			this.Weight = _weight;
		}

		public double Weight
		{
			get { return _weight; }
			set
			{
				if (value < MinWeight || value > MaxWeight)
				{
					throw new ArgumentException("Dough weight should be in the range [1..200].");
				}
				_weight = value;
			}
		}


		public string BackingTechnique
		{
			get { return _backingTechnique; }
			set
			{
				if (value.ToLower() != "crispy" && value.ToLower() != "chewy" && value.ToLower() != "homemade")
				{
					throw new ArgumentException("Invalid type of dough.");
				}
				_backingTechnique = value;
			}
		}


		public string FlourType
		{

			get { return _flourType; }
			set
			{
				if (value.ToLower() != "wholegrain" && value.ToLower() != "white")
				{
					throw new ArgumentException("Invalid type of dough.");
				}
				_flourType = value;
			}
		}

		public double GetCalories()
		{
			return 2 * this.Weight * this.GetTechMod() * this.GetTypeMod();
		}

		private double GetTypeMod()
		{
			if (this.FlourType.ToLower() == "white")
			{
				return 1.5;
			}

			return 1.0;
		}

		double GetTechMod()
		{
			if (BackingTechnique.ToLower() == "crispy")
				return 0.9;
			else if (BackingTechnique.ToLower() == "chewy")
				return 1.1;
			return 1;
		}

	}
}
