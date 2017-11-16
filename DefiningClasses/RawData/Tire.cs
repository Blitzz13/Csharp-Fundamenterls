using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RawData
{
    class Tire
    {
        public int tireAge;
        public double tirePressure;

        public Tire(int tireAge, double tirePressure)
        {
            this.tireAge = tireAge;
            this.tirePressure = tirePressure;
        }
    }
}
