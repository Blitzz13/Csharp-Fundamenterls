using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WildFarm.Animals;

namespace WildFarm
{
	public class Program
	{
		static void Main(string[] args)
		{
			int counter = 1;
			string line = Console.ReadLine();
			var animals = new List<Animal>();
			int currentAnimal = 0;
			Animal previousAnimal = new Animal();
			while (line != "End")
			{
				string[] tokens = line.Split();
				if (counter % 2 != 0)
				{
					string animalType = tokens[0];
					string animalName = tokens[1];
					double animalWeight = double.Parse(tokens[2]);
					string livingRegion = tokens[3];

					if (tokens[0].ToLower() != "cat")
					{
						Mammal mammal = new Mammal(animalName, animalType, animalWeight, livingRegion);
						UpdateAnimalList(animals, animalName, mammal);
						GetAnimal(animals, animalName);
						previousAnimal = GetAnimal(animals, animalName);
						currentAnimal++;
					}
					else
					{
						string breed = tokens.Last();
						Cat cat = new Cat(animalName, animalType, animalWeight, livingRegion, breed);
						UpdateAnimalList(animals, animalName, cat);
						previousAnimal = GetAnimal(animals, animalName);
						currentAnimal++;
					}

				}
				else
				{
					int foodEaten = int.Parse(tokens[1]);
					DetermineIfAnimalWillEatFood(previousAnimal, tokens[0], foodEaten);
				}

				counter++;
				line = Console.ReadLine();
			}

			foreach (var animal in animals)
			{
				Console.WriteLine(animal);
			}

		}

		private static void UpdateAnimalList(List<Animal> animals, string animalName, Mammal mammal)
		{
			Animal animal = animals.FirstOrDefault(a => a.AnimalName == animalName);
			if (animal == null)
			{
				animals.Add(mammal);
			}

		}

		static void DetermineIfAnimalWillEatFood(Animal animal, string foodType, int foodEaten)
		{
			if (foodType == "Vegetable" && animal.AnimaType != "Tiger")
			{
				animal.FoodEaten += foodEaten;
				animal.MakeSound();
				return;
			}
			else if (foodType != "Vegetable" && (animal.AnimaType == "Tiger" || animal.AnimaType == "Cat"))
			{
				animal.FoodEaten += foodEaten;
				animal.MakeSound();
				return;
			}

			animal.MakeSound();
			Console.WriteLine($"{animal.AnimaType}s are not eating that type of food!");
		}

		public static Animal GetAnimal(List<Animal> animals, string animalName)
		{
			Animal animal = animals.FirstOrDefault(a => a.AnimalName == animalName);
			return animal;
		}
	}
}
