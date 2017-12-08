using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BirthdayCelebrations
{
	class Program
	{
		static void Main(string[] args)
		{
			List<Being> beings = new List<Being>();

			string[] line = Console.ReadLine().Split();

			while (line[0] != "End")
			{
				if (line[0] == "Citizen")
				{
					var citizen = new Citizen(line[1], int.Parse(line[2]), line[3], line[4]);
					beings.Add(citizen);
				}
				else if (line[0] == "Pet")
				{
					var pet = new Pet(line[1], line[2]);
					beings.Add(pet);
				}

				line = Console.ReadLine().Split();
			}

			string dateToSearch = Console.ReadLine();
			beings.Where(a => a.BirthDate.Substring(a.BirthDate.Length - dateToSearch.Length) == dateToSearch)
				.ToList().ForEach(a => Console.WriteLine(a.BirthDate));
		}
	}
}
