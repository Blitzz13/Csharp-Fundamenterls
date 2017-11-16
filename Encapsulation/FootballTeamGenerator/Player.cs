using System;

namespace FootballTeamGenerator
{
	class Player
	{
		private string name;
		private int endurence;
		private int sprint;
		private int dribble;
		private int passing;
		private int shooting;

		public Player(string name, int endurence, int sprint, int dribble, int passing, int shooting)
		{
			this.Name = name;
			this.Endurence = endurence;
			this.Sprint = sprint;
			this.Dribble = dribble;
			this.Passing = passing;
			this.Shooting = shooting;
		}

		public string Name
		{
			get { return this.name; }
			set
			{
				if (string.IsNullOrEmpty(name))
				{
					throw new ArgumentException("A name should not be empty. ");
				}

				this.name = value;
			}
		}

		public int Endurence
		{
			get { return this.endurence; }
			set
			{
				ValidateStats(value, nameof(Endurence));
				this.endurence = value;
			}
		}

		public int Sprint
		{
			get { return this.sprint; }
			set
			{
				ValidateStats(value, nameof(Sprint));
				this.sprint = value;
			}
		}

		public int Dribble
		{
			get { return this.dribble; }
			set
			{
				ValidateStats(value, nameof(Dribble));
				this.dribble = value;
			}
		}

		public int Passing
		{
			get { return this.passing; }
			set
			{
				ValidateStats(value, nameof(Passing));
				this.passing = value;
			}
		}

		public int Shooting
		{
			get { return this.shooting; }
			set
			{
				ValidateStats(value, nameof(Shooting));
				this.shooting = value;
			}
		}

		public void ValidateStats(int value, string name)
		{
			if (value < 0 || value > 100)
			{
				throw new ArgumentException($"{name} should be between 0 and 100.");
			}
		}
	}
}
