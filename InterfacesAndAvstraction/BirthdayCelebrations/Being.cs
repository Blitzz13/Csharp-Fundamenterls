namespace BirthdayCelebrations
{
	abstract class Being : ILivingBeing, IBeing
	{
		public string Name { get; set; }
		public string BirthDate { get; set; }
		public string Id { get; set; }
	}
}