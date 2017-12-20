using System;
using System.Collections;
using System.Collections.Generic;

namespace Froggy
{
	class Lake : IEnumerable<int>
	{
		private IList<int> stones;

		public Lake(List<int> list)
		{
			this.Stones = list;
		}

		public IList<int> Stones
		{
			get { return stones; }
			set { stones = value; }
		}

		public IEnumerator<int> GetEnumerator()
		{
			for (int i = 0; i < stones.Count; i++)
			{
				yield return stones[i];
			}
		}

		IEnumerator IEnumerable.GetEnumerator()
		{
			return GetEnumerator();
		}
	}
}
