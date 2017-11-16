using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class Car
{
    private string model;
    private double fuelAmount;
    private double fuelConsumption;
    private double distanceTravelled;

    public Car(string model, double fuelAmount, double fuelConsumption)
    {
        this.model = model;
        this.fuelAmount = fuelAmount;
        this.fuelConsumption = fuelConsumption;
        this.distanceTravelled = 0;
    }

    public Car()
    {

    }

    public void CanTheCarGoThere(string model, double kilometers, List<Car> cars)
    {
        foreach (var car in cars)
        {
            if (car.model == model)
            {
                var fuelLeft = car.fuelAmount - (car.fuelConsumption * kilometers);
                if (fuelLeft >= 0)
                {
                    car.distanceTravelled += kilometers;
                    car.fuelAmount = fuelLeft;
                }
                else
                {
                    Console.WriteLine("Insufficient fuel for the drive");
                }
            }
        }
    }

    public void PrintCars(List<Car> cars)
    {
        cars.ForEach(a => Console.WriteLine($"{a.model} {a.fuelAmount:F2} {a.distanceTravelled}"));
    }

}

