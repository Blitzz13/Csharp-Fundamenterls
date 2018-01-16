using System;
using System.Collections.Generic;

class Program
{
	static void Main()
	{
		string[] tokens = Console.ReadLine().Split();
		Lights light;

		int n = int.Parse(Console.ReadLine());
		IList<Enum> lights = new List<Enum>();

		for (int i = 0; i < tokens.Length; i++)
		{
			Enum.TryParse(tokens[i], out light);
			lights.Add(light);
		}

		int counter = 0;
		for (int i = 0; i < n; i++)
		{
			for (int j = 0; j < lights.Count; j++)
			{
				switch (lights[j])
				{
					case Lights.Red:
						lights[counter] = Lights.Green;
						break;
					case Lights.Green:
						lights[counter] = Lights.Yellow;
						break;
					case Lights.Yellow:
						lights[counter] = Lights.Red;
						break;
				}

				counter++;
			}

			counter = 0;
			Console.WriteLine(string.Join(" ", lights));
		}
	}

}
