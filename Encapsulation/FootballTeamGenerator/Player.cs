using System;


public class Player
{
	private string name;
	private int endurance;
	private int sprint;
	private int dribble;
	private int passing;
	private int shooting;
	private double playerRating;

	public Player(string name, int endurance, int sprint, int dribble, int passing, int shooting)
	{
		this.Name = name;
		this.Endurance = endurance;
		this.Sprint = sprint;
		this.Dribble = dribble;
		this.Passing = passing;
		this.Shooting = shooting;
	}

	public double PlayerRating
	{
		get { return playerRating; }
		set { playerRating = value; }
	}

	public string Name
	{
		get { return this.name; }
		set
		{
			if (string.IsNullOrEmpty(value))
			{
				throw new ArgumentException("A name should not be empty. ");
			}

			this.name = value;
		}
	}

	public int Endurance
	{
		get { return this.endurance; }
		set
		{
			ValidateStats(value, nameof(Endurance));
			this.endurance = value;
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

	public double RatePlayer()
	{
		return PlayerRating = (double)(this.Passing + this.Endurance + this.Dribble + this.Shooting + this.Sprint) / 5;
	}
}
