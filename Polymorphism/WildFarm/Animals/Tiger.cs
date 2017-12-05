namespace WildFarm.Animals
{
	class Tiger : Felime
	{
		private string livingRegion;

		public Tiger(string animalName, string animalType, double animalWeight, string livingRegion) 
			: base(animalName, animalType, animalWeight, livingRegion)
		{
			this.LivingRegion = this.livingRegion;
		}

		public string LivingRegion
		{
			get { return livingRegion; }
			set { livingRegion = value; }
		}
	}
}
