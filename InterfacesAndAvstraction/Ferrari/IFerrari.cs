using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ferrari
{
	interface IFerrari
	{
		string Model { get; set; }
		string Driver { get; set; }
		string GasPedal { get; set; }
		string Brakes { get; set; }
	}
}
