using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace ClassBox
{
	class Program
	{
		static void Main(string[] args)
		{
			Type boxType = typeof(Box);
			FieldInfo[] fields = boxType.GetFields(BindingFlags.NonPublic | BindingFlags.Instance);
			Console.WriteLine(fields.Count());

			try
			{
				var boxParams = new double[3];

				for (int i = 0; i < 3; i++)
				{
					boxParams[i] = double.Parse(Console.ReadLine());
				}

				var box = new Box(boxParams[0], boxParams[1], boxParams[2]);

				Console.WriteLine($"Surface Area - {box.GetSurfaceArea():F2}");
				Console.WriteLine($"Lateral Surface Area - {box.GetLateralSurfaceArea():F2}");
				Console.WriteLine($"Volume - {box.GetVolumeArea():F2}");
			}
			catch (ArgumentException ae)
			{
				Console.WriteLine(ae.Message);
			}
		}
	}
}
