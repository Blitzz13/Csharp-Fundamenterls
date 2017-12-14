using System;
using System.Collections.Generic;

namespace MilitaryElite
{
	class Program
	{
		static void Main(string[] args)
		{

			string[] line = Console.ReadLine().Split();

			var dictOfPrivates = new Dictionary<int, Private>();
			var soldiers = new List<ISoldier>();
			while (line[0] != "End")
			{
				if (line[0] == "Private")
				{
					var @private = new Private(int.Parse(line[1]), line[2], line[3], double.Parse(line[4]));
					dictOfPrivates.Add(int.Parse(line[1]), @private);
					soldiers.Add(@private);
				}
				else if (line[0] == "LeutenantGeneral")
				{
					var leutenantGeneral = new LeutenantGeneral(int.Parse(line[1]), line[2], line[3], double.Parse(line[4]));
					leutenantGeneral.Privates = new List<Private>();
					for (int i = 5; i < line.Length; i++)
					{
						leutenantGeneral.Privates.Add(dictOfPrivates[int.Parse(line[i])]);
					}

					soldiers.Add(leutenantGeneral);
				}
				else if (line[0] == "Engineer")
				{
					var engineer = new Engineer(int.Parse(line[1]), line[2], line[3], double.Parse(line[4]), line[5]);
					for (int i = 6; i < line.Length; i += 2)
					{
						var repair = new Repair(int.Parse(line[i]), line[i + 1]);
						engineer.Repairs.Add(repair);
					}

					soldiers.Add(engineer);
				}
				else if (line[0] == "Commando")
				{
					var commando = new Commando(int.Parse(line[1]), line[2], line[3], double.Parse(line[4]), line[5]);
					commando.Missions = new List<Mission>();
					for (int i = 6; i < line.Length; i += 2)
					{
						var mission = new Mission(line[i], line[i + 1]);
						commando.Missions.Add(mission);
					}

					soldiers.Add(commando);
				}
				else if (line[0] == "Spy")
				{
					var spy = new Spy(int.Parse(line[1]), line[2], line[3], double.Parse(line[4]), int.Parse(line[5]));

					soldiers.Add(spy);
				}

				line = Console.ReadLine().Split();
			}

			foreach (var soldier in soldiers)
			{
				Console.WriteLine(soldier);
			}
		}

	}

}
