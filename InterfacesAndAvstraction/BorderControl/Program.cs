using System;
using System.Collections.Generic;

public class Program
{
	static void Main()
	{
		string[] line = Console.ReadLine().Split();
		var beings = new List<Being>();

		while (line[0] != "End")
		{
			string id = "";

			if (line.Length == 2)
			{
				var robot = new Robot(line[0],line[1]);
				beings.Add(robot);
			}
			else
			{
				var citizen = new Citizen(line[0],int.Parse(line[1]), line[2]);
				beings.Add(citizen);
			}

			line = Console.ReadLine().Split();
		}

		string fakeDigits = Console.ReadLine();

		foreach (Being being in beings)
		{
			DetermineIfIdIsFake(being.Id, fakeDigits);
		}

	}

	public static void DetermineIfIdIsFake(string id, string fakeDigits)
	{
		string lastIdDigits = id.Substring(id.Length - fakeDigits.Length);
		if (lastIdDigits == fakeDigits)
		{
			Console.WriteLine(id);
		}

	}

}
