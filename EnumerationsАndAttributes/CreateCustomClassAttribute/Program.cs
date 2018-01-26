using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace CreateCustomClassAttribute
{
	class Program
	{
		static void Main(string[] args)
		{
			string command = Console.ReadLine();
			PropertyInfo[] props = typeof(Weapon).GetProperties();
			while (command != "END")
			{
				switch (command)
				{
					case "Author":
						props.
						break;
				}
				
			}
		}
	}
}
