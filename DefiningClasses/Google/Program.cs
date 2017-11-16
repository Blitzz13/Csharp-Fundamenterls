using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Program
{
    static void Main(string[] args)
    {
        var line = Console.ReadLine().Split();
        Dictionary<string, Person> people = new Dictionary<string, Person>();
        while (line[0] != "End")
        {
            var name = line[0];
            if (!people.ContainsKey(name))
            {
                var person = new Person();
                people.Add(name, person);
            }
            var comapny = new Company();
            var pokemon = new Pokemon();
            var parent = new Parent();
            var child = new Child();
            var car = new Car();
            if (line[1] == "company")
            {
                comapny = new Company
                {
                    CompanyName = line[2],
                    Department = line[3],
                    Salary = double.Parse(line[4])
                };
                people[name].Company = comapny;
            }
            else if (line[1] == "pokemon")
            {
                pokemon = new Pokemon
                {
                    PokeName = line[2],
                    PokeType = line[3]
                };

                people[name].Pokemons.Add(pokemon);
            }
            else if (line[1] == "parents")
            {
                parent = new Parent
                {
                    ParentName = line[2],
                    ParentBirthday = line[3]
                };

                people[name].Parents.Add(parent);
            }
            else if (line[1] == "children")
            {
                child = new Child
                {
                    childName = line[2],
                    childBirthday = line[3]
                };

                people[name].Children.Add(child);
            }
            else if (line[1] == "car")
            {
                car = new Car
                {
                    CarModel = line[2],
                    CarSpeed = double.Parse(line[3])
                };

                people[name].Car = car;
            }

            line = Console.ReadLine().Split();
        }

        var nameToSearch = Console.ReadLine();

        var finalPerson = people.FirstOrDefault(a => a.Key == nameToSearch);

        Console.WriteLine(finalPerson.Key);
        Console.WriteLine("Company:");
        try
        {
            Console.WriteLine($@"{finalPerson.Value.Company.CompanyName} {finalPerson.Value.Company.Department} {finalPerson.Value.Company.Salary:f2}");

        }
        catch
        {
        }
        Console.WriteLine("Car:");
        try
        {
            Console.WriteLine(finalPerson.Value.Car.CarModel + " " + finalPerson.Value.Car.CarSpeed);
        }
        catch 
        {
        }
        
        Console.WriteLine("Pokemon:");
        foreach (var pokemon in finalPerson.Value.Pokemons)
        {
            Console.WriteLine(pokemon.PokeName + " " + pokemon.PokeType);
        }
        Console.WriteLine("Parents:");
        foreach (var parent in finalPerson.Value.Parents)
        {
            Console.WriteLine(parent.ParentName + " " + parent.ParentBirthday);
        }
        Console.WriteLine("Children:");
        foreach (var child in finalPerson.Value.Children)
        {
            Console.WriteLine(child.childName + " " + child.childBirthday);
        }

    }
}

