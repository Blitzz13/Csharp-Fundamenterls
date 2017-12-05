using System;

namespace WildFarm
{
	public class Animal
	{
		private string animalName;
		private string animalType;
		private double animalWeight;
		private int foodEaten;

		public Animal(string animalName, string animalType, double animalWeight)
		{
			this.AnimalName = animalName;
			this.AnimaType = animalType;
			this.AnimalWeight = animalWeight;
		}

		public Animal()
		{
			
		}

		public int FoodEaten
		{
			get { return foodEaten; }
			set { foodEaten = value; }
		}

		public double AnimalWeight
		{
			get { return animalWeight; }
			set { animalWeight = value; }
		}

		public string AnimaType
		{
			get { return animalType; }
			set { animalType = value; }
		}

		public string AnimalName
		{
			get { return animalName; }
			set { animalName = value; }
		}

		public void MakeSound()
		{
			if (this.AnimaType.ToLower() == "cat")
			{
				Console.WriteLine("Meowwww");
			}
			else if (this.AnimaType.ToLower() == "tiger")
			{
				Console.WriteLine("ROAAR!!!");
			}
			else if (this.AnimaType.ToLower() == "zebra")
			{
				Console.WriteLine("Zs");
			}
			else if (this.AnimaType.ToLower() == "mouse")
			{
				Console.WriteLine("SQUEEEAAAK!");
			}
		}

		public void Eat(Food food)
		{

		}
	}
}
