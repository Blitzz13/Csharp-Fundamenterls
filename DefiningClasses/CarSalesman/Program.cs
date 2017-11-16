using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarSalesman
{
    class Program
    {
        static void Main()
        {
            var numberOfEngines = int.Parse(Console.ReadLine());
            List<Engine> engines = new List<Engine>();
            List<Car> cars = new List<Car>();
            for (int i = 0; i < numberOfEngines; i++)
            {
                var line = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                var model = line[0];
                var power = double.Parse(line[1]);

                double displacement = 0;
                string efficiency = null;
                var engine = new Engine(model, power);

                if (line.Length == 3)
                {
                    try
                    {
                        displacement = double.Parse(line[2]);
                        engine.displacement = displacement;
                    }
                    catch
                    {
                        efficiency = line[2];
                        engine.efficiency = efficiency;
                    }
                    engines.Add(engine);
                }
                else if (line.Length == 4)
                {
                    displacement = double.Parse(line[2]);
                    efficiency = line[3];
                    engine.efficiency = efficiency;
                    engine.displacement = displacement;
                    engines.Add(engine);
                }else if (line.Length == 2)
                {
                    engines.Add(engine);
                }
            }

            var numberOfCars = int.Parse(Console.ReadLine());

            for (int i = 0; i < numberOfCars; i++)
            {
                var line = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                var carModel = line[0];
                var engineModel = engines.First(a => a.EngineModel == line[1]);
                double weight;
                string color;

                var car = new Car(carModel, engineModel);
                if (line.Length == 3)
                {
                    try
                    {
                        weight = double.Parse(line[2]);
                        car.weight = weight;
                    }
                    catch
                    {
                        color = line[2];
                        car.color = color;
                    }
                    cars.Add(car);
                }
                else if (line.Length == 4)
                {
                    weight = double.Parse(line[2]);
                    color = line[3];
                    car.color = color;
                    car.weight = weight;
                    cars.Add(car);
                }
                else if (line.Length == 2)
                {
                    cars.Add(car);
                }
            }

            //print

            foreach (var car in cars)
            {
                Console.WriteLine($"{car.CarModel}:");
                Console.WriteLine($"  {car.Engine.EngineModel}:");
                Console.WriteLine($"    Power: {car.Engine.Power}");
                if (car.Engine.Displacement == 0)
                {
                    Console.WriteLine($"    Displacement: n/a");
                }
                else
                {
                    Console.WriteLine($"    Displacement: {car.Engine.Displacement}");
                }
                if (car.Engine.Efficiency == null)
                {
                    Console.WriteLine($"    Efficiency: n/a");
                }
                else
                {
                    Console.WriteLine($"    Efficiency: {car.Engine.Efficiency}");
                }
                if (car.Weight == 0)
                {
                    Console.WriteLine($"  Weight: n/a");
                }
                else
                {
                    Console.WriteLine($"  Weight: {car.Weight}");
                }
                if (car.Color == null)
                {
                    Console.WriteLine($"  Color: n/a");
                }
                else
                {
                    Console.WriteLine($"  Color: {car.Color}");
                }
            }
        }
    }
}