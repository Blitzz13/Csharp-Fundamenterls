using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ferrari
{
	class Ferrari : IFerrari
	{
		public Ferrari(string driver)
		{
			this.Model = "488-Spider";
			this.Driver = driver;
			this.Brakes = "Brakes!";
			this.GasPedal = "Zadu6avam sA!";
		}

		public string Model { get; set; }
		public string Driver { get; set; }
		public string GasPedal { get; set; }
		public string Brakes { get; set; }

		public override string ToString()
		{
			return $"{Model}/{Brakes}/{GasPedal}/{Driver}";
		}
	}
}
