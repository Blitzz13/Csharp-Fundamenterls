using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PopulationCounter
{
    class PopulationCounter
    {
        static void Main(string[] args)
        {
            var tokens = Console.ReadLine().Split('|').ToList();
            var countries = new Dictionary<string, Dictionary<string, double>>();
            while (tokens[0] != "report")
            {
                var town = tokens[0];
                var country = tokens[1];
                var population = double.Parse(tokens[2]);
                if (countries.ContainsKey(country))
                {
                    if (countries[country].ContainsKey(town))
                    {
                        countries[country][town] += population;
                    }
                    else
                    {
                        countries[country][town] = population;
                    }

                }
                else
                {
                    countries.Add(country, new Dictionary<string, double> {{town, population}});
                }
                tokens = Console.ReadLine().Split('|').ToList();
            }

            countries.OrderBy(a => a.Value.Values.Sum());

            foreach (var country in countries.OrderByDescending(a => a.Value.Values.Sum()))
            {
                Console.WriteLine($"{country.Key} (total population: {country.Value.Values.Sum()})");
                foreach (var city in country.Value.OrderByDescending(a => a.Value))
                {
                    Console.WriteLine($"=>{city.Key}: {city.Value}");
                }
            }
        }
    }

}
