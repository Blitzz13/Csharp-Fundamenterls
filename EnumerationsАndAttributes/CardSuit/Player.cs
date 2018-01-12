using System.Collections.Generic;

class Player
{
	public string Name { get; set; }
	public List<Card> Hand { get; set; }
	public int Power { get; set; }
	public Card BestCard { get; set; }

	public Player(string name)
	{
		this.Name = name;
		this.Hand = new List<Card>();
	}

	public override string ToString()
	{
		return $"{this.Name} wins with {BestCard}.";
	}
}
