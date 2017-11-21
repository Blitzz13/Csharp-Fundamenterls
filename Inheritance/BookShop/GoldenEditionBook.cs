class GoldenEditionBook : Book
{
	public GoldenEditionBook(string _author, string _title, decimal _price)
		: base(_author, _title, _price)
	{
	}

	public override decimal Price
	{
		get
		{
			return base.Price * (decimal)1.3;
		}
	}

}