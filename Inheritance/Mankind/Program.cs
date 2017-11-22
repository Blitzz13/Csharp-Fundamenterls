using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mankind
{
	public class Program
	{
		static void Main(string[] args)
		{
			try
			{
				string[] line = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
				var student = new Student(line[0], line[1], line[2]);
				line = Console.ReadLine().Split(new[] {' '}, StringSplitOptions.RemoveEmptyEntries);
				var worker = new Worker(line[0], line[1], double.Parse(line[2]), double.Parse(line[3]));

				Console.WriteLine(student);
				Console.WriteLine(worker);
			}
			catch (ArgumentException ae)
			{
				Console.WriteLine(ae.Message);
			}
		}

		
	}
}
