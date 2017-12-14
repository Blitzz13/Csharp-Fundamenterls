namespace MilitaryElite
{
	class Repair
	{
		private string _name;
		private int _hoursWorked;

		public Repair(int hoursWorked, string name)
		{
			this.HoursWorked = hoursWorked;
			this.Name = name;
		}

		string Name
		{
			get => _name;
			set => _name = value;
		}

		int HoursWorked
		{
			get => _hoursWorked;
			set => _hoursWorked = value;
		}
	}
}
