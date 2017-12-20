using System;
using System.Collections.Generic;
using System.Linq;


public class Program
{
	public static void Main(string[] args)
	{
		List<string> line = Console.ReadLine()
			.Split(new[] { ' ', ',' }, StringSplitOptions.RemoveEmptyEntries).ToList();
		Stack<string> stack = new Stack<string>();
		while (line[0] != "END")
		{
			try
			{
				if (line[0] == "Push")
				{
					line.RemoveAt(0);
					stack.Push(line);
				}
				else if (line[0] == "Pop")
				{
					stack.Pop();
				}
			}
			catch (ArgumentException ae)
			{
				Console.WriteLine(ae.Message);
			}

			line = Console.ReadLine().Split(new[] { ' ', ',' }, StringSplitOptions.RemoveEmptyEntries).ToList();
		}

		for (var index = stack.List.Count - 1; index >= 0; index--)
		{
			var element = stack.List[index];
			Console.WriteLine(element);
		}

		for (var index = stack.List.Count - 1; index >= 0; index--)
		{
			var element = stack.List[index];
			Console.WriteLine(element);
		}

	}
}
