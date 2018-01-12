using System;
using System.Collections.Generic;

class Program
{
	static void Main()
	{
		var deck = CreateDeck();

		string player1Name = Console.ReadLine();
		string player2Name = Console.ReadLine();

		var player1 = new Player(player1Name);
		var player2 = new Player(player2Name);
		MakeHand(deck, player1.Hand, player2.Hand, player1.Hand, player1);
		MakeHand(deck, player1.Hand, player2.Hand, player2.Hand, player2);

		if (player1.Power > player2.Power)
		{
			Console.WriteLine(player1);
		}
		else
		{
			Console.WriteLine(player2);
		}
	}

	private static void MakeHand(List<Card> deck, List<Card> firstPlayerHand, List<Card> secondPlayerHand, List<Card> handToFill, Player player)
	{
		while (handToFill.Count != 5)
		{
			string[] tokens = Console.ReadLine().Split(new[] { " ", "of" }, StringSplitOptions.RemoveEmptyEntries);
			var tempCard = new Card(tokens[0], tokens[1]);
			var cardInDeck = deck.Find(a => a.CardSuitInput == tempCard.CardSuitInput && a.CardRankInput == tempCard.CardRankInput);
			var playerOneCard = firstPlayerHand.Find(a => a.CardSuitInput == tempCard.CardSuitInput && a.CardRankInput == tempCard.CardRankInput);
			var playerTwoCard = secondPlayerHand.Find(a => a.CardSuitInput == tempCard.CardSuitInput && a.CardRankInput == tempCard.CardRankInput);

			if (cardInDeck != null && firstPlayerHand.Contains(tempCard) == false && secondPlayerHand.Contains(tempCard) == false)
			{
				handToFill.Add(tempCard);
				deck.Remove(cardInDeck);
				if (tempCard.Power > player.Power)
				{
					player.Power = tempCard.Power;
					player.BestCard = new Card(tokens[0], tokens[1]);
				}

			}
			else if (playerOneCard == null && playerTwoCard == null && cardInDeck == null)
			{
				Console.WriteLine("No such card exists.");
			}
			else if (playerOneCard != null || playerTwoCard != null)
			{
				Console.WriteLine("Card is not in the deck.");
			}

		}
	}

	private static void GetInput()
	{
		string input = Console.ReadLine();

		if (input == "Rank")
		{
			PrintAttribute(typeof(Rank));
		}
		else
		{
			PrintAttribute(typeof(Suit));
		}
	}

	private static void PrintAttribute(Type type)
	{
		var attributes = type.GetCustomAttributes(false);
		Console.WriteLine(attributes[0]);
	}

	private static List<Card> CreateDeck()
	{
		List<Card> deck = new List<Card>();

		foreach (var suit in Enum.GetNames(typeof(Suit)))
		{
			foreach (var rank in Enum.GetNames(typeof(Rank)))
			{
				deck.Add(new Card(rank, suit));
			}
		}

		return deck;
	}
}