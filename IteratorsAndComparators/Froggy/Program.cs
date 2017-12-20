using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace Froggy
{
	class Program
	{
		static void Main(string[] args)
		{
			Lake lake = new Lake(Console.ReadLine().Split(new[] { ' ', ',' }, StringSplitOptions.RemoveEmptyEntries)
				.Select(int.Parse).ToList());
			IList<int> stones = lake.Stones;
			IList<int> even = new List<int>();
			IList<int> odd = new List<int>();

			for (int i = 0; i < lake.Stones.Count; i++)
			{
				if (i % 2 == 0)
				{
					even.Add(stones[i]);
				}
				else
				{
					odd.Add(stones[i]);
				}
			}

			List<int> combined = new List<int>();

			combined.AddRange(even);
			combined.AddRange(odd.Reverse());

			Console.WriteLine(string.Join(", ", combined));
		}
	}
}
