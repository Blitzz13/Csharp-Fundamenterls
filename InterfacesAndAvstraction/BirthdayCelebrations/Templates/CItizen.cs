namespace BirthdayCelebrations
{
	class Citizen : Being
	{
		public Citizen(string name, int age, string id, string birthDate)
		{
			this.Name = name;
			this.Age = age;
			this.Id = id;
			this.BirthDate = birthDate;
		}

		public int Age { get; set; }

		public override void BuyFood()
		{
			this.Food += 10;
		}
	}
}