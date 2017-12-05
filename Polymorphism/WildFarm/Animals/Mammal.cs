namespace WildFarm
{
	public class Mammal : Animal
	{
		private string livingRegion;

		public Mammal(string animalName, string animalType, double animalWeight, string livingRegion) 
			: base(animalName, animalType, animalWeight)
		{
			this.LivingRegion = livingRegion;
		}
		public string LivingRegion
		{
			get { return livingRegion; }
			set { livingRegion = value; }
		}

		public override string ToString()
		{
			return $"{AnimaType}[{AnimalName}, {AnimalWeight}, {LivingRegion}, {FoodEaten}]";
		}
	}
}
