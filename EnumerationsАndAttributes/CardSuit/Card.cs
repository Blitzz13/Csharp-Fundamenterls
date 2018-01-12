using System;

class Card : IComparable<Card>
{
	private string _cardRankInput;
	private string _cardSuitInput;

	public int Power => GetCardPower();

	public string CardSuitInput
	{
		get { return _cardSuitInput; }
		set { _cardSuitInput = value; }
	}

	public string CardRankInput
	{
		get { return _cardRankInput; }
		set { _cardRankInput = value; }
	}

	public Card(string cardRank, string cardSuit)
	{
		_cardRankInput = cardRank;
		_cardSuitInput = cardSuit;
	}

	public override string ToString()
	{
		int cardPower = GetCardPower();
		return $"{this.CardRankInput} of {this.CardSuitInput}";
	}

	private int GetCardPower()
	{
		return (int)Enum.Parse(typeof(Rank), this.CardRankInput) +
									(int)Enum.Parse(typeof(Suit), this.CardSuitInput);
	}

	public int CompareTo(Card other)
	{
		if (other.CardRankInput == this.CardRankInput && other.CardSuitInput == this.CardSuitInput)
		{
			return 0;
		}

		if (other.Power < this.Power)
		{
			return 1;
		}

		return -1;
	}
}
