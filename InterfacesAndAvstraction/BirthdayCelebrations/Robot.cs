namespace BirthdayCelebrations
{
	class Robot : Being
	{
		public Robot(string model, string id)
		{
			this.Model = model;
			this.Id = id;
		}

		public string Model { get; set; }
	}
}