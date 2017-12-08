using System;
using System.Collections.Generic;
using System.Linq;

namespace BirthdayCelebrations
{
	public class Program
	{
		public static void Main(string[] args)
		{
			int n = int.Parse(Console.ReadLine());
			List<Being> people = new List<Being>();

			for (int i = 0; i < n; i++)
			{

				string[] line = Console.ReadLine().Split();
				if (line.Length == 4)
				{
					var citizen = new Citizen(line[0], int.Parse(line[1]), line[2], line[3]);
					people.Add(citizen);
				}
				else
				{
					var rebel = new Rebel(line[0], int.Parse(line[1]), line[2]);
					people.Add(rebel);
				}

			}

			string name = Console.ReadLine();
			while (name != "End")
			{
				var foundPerson = people.FirstOrDefault(a => a.Name == name);
				if (foundPerson != null)
				{
					foundPerson.BuyFood();
				}

				name = Console.ReadLine();
			}
			Console.WriteLine(people.Sum(a => a.Food));
		}
	}
}
