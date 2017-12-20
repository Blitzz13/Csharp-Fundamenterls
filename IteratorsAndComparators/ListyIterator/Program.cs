using System;
using System.Collections.Generic;
using System.Linq;

namespace ListyIterator
{
	public class Program
	{
		static void Main(string[] args)
		{
			List<string> line = Console.ReadLine().Split().ToList();
			ListyIterator<string> iterator = new ListyIterator<string>();
			while (line[0] != "END")
			{
				try
				{
					if (line[0] == "Create")
					{
						var list = new List<string>();
						line.RemoveAt(0);
						list.AddRange(line);
						iterator = new ListyIterator<string>(list);
					}
					else if (line[0] == "Move")
					{
						Console.WriteLine(iterator.Move());
					}
					else if (line[0] == "Print")
					{
						iterator.Print();
					}
					else if (line[0] == "HasNext")
					{
						Console.WriteLine(iterator.HasNext());
					}
					else if (line[0] == "PrintAll")
					{
						foreach (var item in iterator)
						{
							Console.Write($"{item} ");
						}

						Console.WriteLine();
					}

				}
				catch (ArgumentException argumentException)
				{
					Console.WriteLine(argumentException.Message);
				}

				line = Console.ReadLine().Split().ToList();
			}
		}
	}
}
