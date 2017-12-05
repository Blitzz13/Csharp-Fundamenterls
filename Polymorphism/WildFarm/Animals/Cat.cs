namespace WildFarm.Animals
{
	class Cat : Felime
	{
		private string breed;

		public Cat(string animalName, string animalType, double animalWeight, string livingRegion, string breed) 
			: base(animalName, animalType, animalWeight, livingRegion)
		{
			this.Breed = breed;
		}

		private string Breed
		{
			get { return breed; }
			set { breed = value; }
		}

		public override string ToString()
		{
			return $"{this.AnimaType}[{AnimalName}, {Breed}, {AnimalWeight}, {LivingRegion}, {FoodEaten}]";
		}
	}
}
