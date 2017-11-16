using System;

namespace FootballTeamGenerator
{
	class FootballTeam
	{
		private int numberOfPlayers;
		private string name;
		private int rating;

		public FootballTeam(string name)
		{
			this.Name = name;
		}

		public string Name
		{
			get { return this.name; }
			set { this.name = value; }
		}

		public int MakeRating()
		{
			
		}
	}
}
