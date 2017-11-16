using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarSalesman
{
    class Car
    {
        private string model;
        private Engine engine;
        public double weight;
        public string color;


        public Car(string model, Engine engine)
        {
            this.model = model;
            this.engine = engine;
        }

        public string CarModel
        {
            get { return this.model; }
        }

        public Engine Engine
        {
            get { return this.engine; }
        }

        public double Weight
        {
            get { return this.weight; }
        }

        public string Color
        {
            get { return this.color; }
        }
    }
}
