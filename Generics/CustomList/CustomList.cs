using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace CustomList
{
	public class CustomList<T> : ICustomList<T>
		where T : IComparable<T>
	{
		private IList<T> list;

		public CustomList() : this (Enumerable.Empty<T>())
		{
		}

		public CustomList(IEnumerable<T> collection)
		{
			this.list = new List<T>(collection);
		}

		public IList<T> List
		{
			get => list;
		}

		public void Add(T element)
		{
			list.Add(element);
		}

		public T Remove(int index)
		{
			T temp = list[index];
			list.RemoveAt(index);
			return temp;
		}

		public bool Contains(T element)
		{
			if (list.Contains(element))
			{
				return true;
			}

			return false;
		}

		public void Swap(int index1, int index2)
		{
			T tempElement = list[index1];
			list[index1] = list[index2];
			list[index2] = tempElement;
		}

		public int CountGreaterThan(T element)
		{
			int result = list.Count(b => b.CompareTo(element) > 0);
			return result;
		}

		public T Max()
		{
			return list.Max();
		}

		public T Min()
		{
			return list.Min();
		}

		public void Print()
		{
			foreach (var item in list)
			{
				Console.WriteLine(item);
			}
		}
	}
}
