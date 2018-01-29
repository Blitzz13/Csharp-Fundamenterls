using System;
using System.IO;
using _02.Blobs.Entities;
using _02.Blobs.Entities.Attacks;
using _02.Blobs.Entities.Behaviors;
using _02.Blobs.Interfaces;

namespace _02.Blobs
{
	public class Program
	{
		public static void Main()
		{
			var file = new StreamReader(@"input.txt");
			string line;
			int counter = 1;
			while ((line = file.ReadLine()) != null)
			{
				string[] tokens = line.Split(new []{' '}, StringSplitOptions.RemoveEmptyEntries);
				string command = tokens[0];

				IBlob player1;
				IBlob player2;
				IBehavior behavior;
				IAttack attack;
				if (tokens[4] == "Inflated")
				{
					behavior = new Inflated();
				}
				else
				{
					behavior = new Aggressive();
				}

				if (tokens[5] == "Blobplode")
				{
					attack = new Blobplode();
				}
				else
				{
					attack = new PutridFart();
				}

				switch (command)
				{
					case "create":
						if (counter == 1)
						{
							player1 = new Blob(tokens[1], int.Parse(tokens[2]), int.Parse(tokens[3]), behavior, attack);
						}
						else
						{
							player2 = new Blob(tokens[1], int.Parse(tokens[2]), int.Parse(tokens[3]), behavior, attack);
						}
						break;
					case "status":
				}
			}

		}
	}
}