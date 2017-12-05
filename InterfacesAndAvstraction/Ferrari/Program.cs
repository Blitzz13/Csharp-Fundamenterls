using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ferrari
{
	class Program
	{
		static void Main(string[] args)
		{
			string name = Console.ReadLine();
			var ferrari = new Ferrari(name);

			Console.WriteLine(ferrari.ToString());
		}
	}
}
