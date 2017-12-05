namespace WildFarm
{
	public abstract class Food
	{
		private int quiantity;

		public Food(int quantity)
		{
			this.Quantity = quantity;
		}

		private int Quantity
		{
			get { return quiantity; }
			set { quiantity = value; }
		}

	}
}
