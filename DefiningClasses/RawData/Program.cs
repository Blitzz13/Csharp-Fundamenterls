using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RawData
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            var line = Console.ReadLine().Split();
            List<Car> cars = new List<Car>();
            for (int i = 0; i < n; i++)
            {

                var model = line[0];
                var engineSpeed = int.Parse(line[1]);
                var enginePower = int.Parse(line[2]);
                var cargoWeight = int.Parse(line[3]);
                var cargoType = line[4];
                var tire1Pressure = double.Parse(line[5]);
                var tire1Age = int.Parse(line[6]);
                var tire2Pressure = double.Parse(line[7]);
                var tire2Age = int.Parse(line[8]);
                var tire3Pressure = double.Parse(line[9]);
                var tire3Age = int.Parse(line[10]);
                var tire4Pressure = double.Parse(line[11]);
                var tire4Age = int.Parse(line[12]);

                var engine = new Engine(engineSpeed, enginePower);
                var cargo = new Cargo(cargoType, cargoWeight);
                var tire1 = new Tire(tire1Age, tire1Pressure);
                var tire2 = new Tire(tire2Age, tire2Pressure);
                var tire3 = new Tire(tire3Age, tire3Pressure);
                var tire4 = new Tire(tire4Age, tire4Pressure);

                List<Tire> tires = new List<Tire>();
                tires.Add(tire1);
                tires.Add(tire2);
                tires.Add(tire3);
                tires.Add(tire4);

                var car = new Car(model, engine, cargo, tires);
                cars.Add(car);

                line = Console.ReadLine().Split();

            }

            string command = line[0];

            if (command == "fragile")
            {
                cars.Where(a => a.cargo.cargoType == "fragile");
                foreach (var car in cars)
                {
                    foreach (var carTire in car.tires)
                    {
                        if (carTire.tirePressure < 1)
                        {
                            Console.WriteLine(car.model);
                            break;
                        }
                    }
                }
            }
            else
            {
                cars.Where(a => a.cargo.cargoType == "flamable" && a.engine.enginePower > 250).ToList()
                    .ForEach(a => Console.WriteLine(a.model));
            }
        }
    }
}
