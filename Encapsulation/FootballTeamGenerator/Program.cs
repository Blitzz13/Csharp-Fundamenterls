using System;
using System.Collections.Generic;
using System.Linq;

public class Program
{
	static void Main(string[] args)
	{
		var input = Console.ReadLine();
		var teams = new Dictionary<string, FootballTeam>();
		while (input != "END")
		{
			var tokens = input.Split(';');

			if (tokens[0] == "Add")
			{
				try
				{
					var player = new Player(tokens[2], int.Parse(tokens[3]), int.Parse(tokens[4]),
						int.Parse(tokens[5]), int.Parse(tokens[6]), int.Parse(tokens[7]));

					teams[tokens[1]].AddPlayer(player);
					teams[tokens[1]].NumberOfPlayers++;
				}
				catch (Exception e)
				{
					Console.WriteLine(e.Message);
				}

			}

			if (tokens[0] == "Remove")
			{
				var playerToRemove = teams[tokens[1]].Players.FirstOrDefault(a => a.Name == tokens[2]);
				if (playerToRemove != null)
				{
					teams[tokens[1]].Players.Remove(playerToRemove);
					teams[tokens[1]].NumberOfPlayers--;
				}
				else
				{
					Console.WriteLine($"Player {tokens[2]} is not in {tokens[1]} team.");
				}
				
			}

			if (tokens[0] == "Team")
			{
				var footballTeam = new FootballTeam(tokens[1]);

				teams.Add(tokens[1], footballTeam);
			}

			if (tokens[0] == "Rating")
			{
				double rating = 0;
				if (teams.ContainsKey(tokens[1]))
				{
					foreach (var player in teams[tokens[1]].Players)
					{
						rating += player.PlayerRating;
					}

					if (teams[tokens[1]].Rating > 0)
					{
						rating /= teams[tokens[1]].Players.Count;
					}

					Console.WriteLine($"{tokens[1]} - {rating:f0}");
				}
				else
				{
					Console.WriteLine($"Team {tokens[1]} does not exist.");
				}

			}

			input = Console.ReadLine();
		}
	}

}

