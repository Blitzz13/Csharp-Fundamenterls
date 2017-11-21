using System.Collections.Generic;

public class FootballTeam
{
	private int numberOfPlayers;
	private string name;
	private int rating;
	private List<Player> players;

	public List<Player> Players
	{
		get { return players; }
		set { players = value; }
	}

	public FootballTeam(string name)
	{
		this.Name = name;
		this.Rating = 0;
		this.Players = new List<Player>();
	}

	public string Name
	{
		get { return this.name; }
		set { this.name = value; }
	}

	public int NumberOfPlayers
	{
		get { return this.numberOfPlayers; }
		set { this.numberOfPlayers = value; }
	}

	public int Rating
	{
		get { return this.rating; }
		set { this.rating = value; }
	}

	public void AddPlayer(Player player)
	{
		this.Players.Add(player);
		player.RatePlayer();
	}
}
