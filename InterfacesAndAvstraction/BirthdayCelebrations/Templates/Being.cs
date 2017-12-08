namespace BirthdayCelebrations
{
	abstract class Being : ILivingBeing, IBeing, IBuyer
	{
		public string Name { get; set; }
		public string BirthDate { get; set; }
		public string Id { get; set; }
		public virtual int Food { get; set; }

		public virtual void BuyFood() { }
	}
}