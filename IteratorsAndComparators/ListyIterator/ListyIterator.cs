using System;
using System.Collections;
using System.Collections.Generic;

namespace ListyIterator
{
	public class ListyIterator<T> : IEnumerable<T>
	{

		private List<T> list;
		private int index;

		public ListyIterator(List<T> list)
		{
			this.List = list;
			this.Index = 0;
		}

		public ListyIterator()
		{
		}

		public List<T> List
		{
			get { return list; }
			set { list = value; }
		}

		public int Index
		{
			get { return index; }
			set { index = value; }
		}
		

		public bool Move()
		{
			if (index + 1 < list.Count)
			{
				this.Index++;
				return true;
			}

			return false;
		}

		public bool HasNext()
		{
			if (index + 1 < list.Count)
			{
				return true;
			}
			return false;
		}

		public void Print()
		{
			if (this.List.Count <= 0)
			{
				throw new ArgumentException("Invalid Operation!");
			}
			Console.WriteLine(list[index]);
		}


		public IEnumerator<T> GetEnumerator()
		{
			for (int i = 0; i < list.Count; i++)
			{
				yield return List[i];
			}
		}

		IEnumerator IEnumerable.GetEnumerator()
		{
			return GetEnumerator();
		}

	}
}
