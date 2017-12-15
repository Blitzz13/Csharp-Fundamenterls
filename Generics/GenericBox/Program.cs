using System;
using System.Collections.Generic;
using System.Linq;

namespace GenericBox
{
	class Program
	{
		static void Main(string[] args)
		{
			int n = int.Parse(Console.ReadLine());
			IList<Box<double>> listOfBoxes = new List<Box<double>>();
			for (int i = 0; i < n; i++)
			{
				Box<double> strBox = new Box<double>(double.Parse(Console.ReadLine()));
				listOfBoxes.Add(strBox);
			}

			double element = double.Parse(Console.ReadLine());
			int result = GetGreaterElementCout(listOfBoxes, element);
			Console.WriteLine(result);
		}

		private static void SwapElements<T>(IList<T> listOfBoxes, int index1, int index2)
		{
			T tempElement = listOfBoxes[index1];
			listOfBoxes[index1] = listOfBoxes[index2];
			listOfBoxes[index2] = tempElement;
		}

		private static int GetGreaterElementCout<T>(IList<Box<double>> listOfBoxes, T element)
			where T : IComparable<T>
		{
			int result = listOfBoxes.Count(b => b.Value.CompareTo(element) > 0);
			return result;
		}
	}
}
