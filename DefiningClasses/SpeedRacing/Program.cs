using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class Program
{
    static void Main()
    {
        var number = int.Parse(Console.ReadLine());
        var line = Console.ReadLine().Split();
        List<Car> cars = new List<Car>();
        var car = new Car();
        for (int i = 0; i < number; i++)
        {
            car = new Car(line[0], double.Parse(line[1]), double.Parse(line[2]));

            cars.Add(car);

            line = Console.ReadLine().Split();
        }

        while (line[0] != "End")
        {
            var model = line[1];
            var kilometers = double.Parse(line[2]);

            car.CanTheCarGoThere(model, kilometers, cars);

            line = Console.ReadLine().Split();
        }

        car.PrintCars(cars);
    }
}

