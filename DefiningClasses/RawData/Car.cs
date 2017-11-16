using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RawData
{
    class Car
    {
        public string model;
        public Engine engine;
        public Cargo cargo;
        public List<Tire> tires;

        public Car(string model, Engine engine, Cargo cargo, List<Tire> tires)
        {
            this.model = model;
            this.engine = engine;
            this.cargo = cargo;
            this.tires = tires;
        }

        public Car()
        {

        }
       
    }
}
