using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarSalesman
{
    class Engine
    {
        private string model;
        private double power;
        public double displacement;
        public string efficiency;

        public Engine(string model, double power)
        {
            this.model = model;
            this.power = power;
        }

        public string EngineModel
        {
            get { return this.model; }
        }

        public double Power
        {
            get { return this.power; }
        }

        public double Displacement
        {
            get { return this.displacement; }
        }

        public string Efficiency
        {
            get { return this.efficiency; }
        }

    }
}
