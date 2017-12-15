using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tuple
{
	public class Tuple<T, T1>
	{

		public Tuple(T item1, T1 item2)
		{
			this.Item1 = item1;
			this.Item2 = item2;
		}

		public T Item1 { get; set; }
		public T1 Item2 { get; set; }

		public override string ToString()
		{
			return $"{this.Item1} -> {this.Item2}";
		}
	}
}
