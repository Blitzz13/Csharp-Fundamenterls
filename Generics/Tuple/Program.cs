using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tuple
{
	class Program
	{
		static void Main(string[] args)
		{
			string[] line = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
			var tupel = new Threeuple<string, string, string>($"{line[0]} {line[1]}", line[2], line[3]);
			Console.WriteLine(tupel);

			line = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
			bool drunk;
			if (line[2] == "drunk")
			{
				drunk = true;
			}
			else
			{
				drunk = false;
			}

			var tupel2 = new Threeuple<string, int, bool>(line[0], int.Parse(line[1]), drunk);
			Console.WriteLine(tupel2);

			line = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
			var tupel3 = new Threeuple<string, double, string>(line[0], double.Parse(line[1]), line[2]);
			Console.WriteLine(tupel3);
		}
	}
}
