namespace MilitaryElite
{
	class Private : IPrivate
	{
		private double _salary;

		public Private(int id, string firstName, string lastName, double salary)
		{
			this.Id = id;
			this.FirstName = firstName;
			this.LastName = lastName;
			this.Salary = salary;
		}

		public int Id { get; set; }
		public string FirstName { get; set; }
		public string LastName { get; set; }
		public double Salary
		{
			get => _salary;
			set =>_salary = value;
		}

		public override string ToString()
		{
			return $"Name: {this.FirstName} {this.LastName} Id: {this.Id} Salary: {this.Salary}";
		}
	}
}
