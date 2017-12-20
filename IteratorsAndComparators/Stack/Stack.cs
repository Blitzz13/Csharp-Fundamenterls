using System;
using System.Collections;
using System.Collections.Generic;

public class Stack<T> : IEnumerable<T>
{
	private int index;
	private List<T> list;

	public Stack()
	{
		this.List = new List<T>();
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

	public void Push(IEnumerable<T> collection)
	{
		this.List.AddRange(collection);
	}

	public void Pop()
	{
		if (this.List.Count <= 0)
		{
			throw new ArgumentException("No elements");
		}
		this.List.RemoveAt(list.Count - 1);
	}

	public IEnumerator<T> GetEnumerator()
	{
		for (int i = this.List.Count - 1; i == 0; i--)
		{
			yield return this.List[i];
		}
	}

	IEnumerator IEnumerable.GetEnumerator()
	{
		return GetEnumerator();
	}
}
