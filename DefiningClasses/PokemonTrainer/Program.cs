using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        var line = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
        Dictionary<string, Trainer> trainers = new Dictionary<string, Trainer>();
        while (line[0] != "Tournament")
        {
            Pokemon pokemon = new Pokemon(line[1], line[2], double.Parse(line[3]));
            Trainer trainer = new Trainer(line[0]);

            if (trainers.ContainsKey(line[0]))
            {
                trainers[line[0]].AddPokemon(pokemon);
            }
            else
            {
                trainer.AddPokemon(pokemon);
                trainers.Add(line[0], trainer);
            }

            line = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
        }

        var element = Console.ReadLine();
        bool takeDamage = true;
        while (element != "End")
        {
            foreach (var trainer in trainers)
            {
                foreach (var pokemon in trainer.Value.pokemons)
                {
                    if (pokemon.element == element)
                    {
                        trainer.Value.numberOfBadges++;
                        takeDamage = false;
                    }
                }
                if (takeDamage)
                {
                    trainer.Value.pokemons.ForEach(a => a.health -= 10);
                }
                trainer.Value.pokemons.RemoveAll(a => a.health <= 0);
                takeDamage = true;

            }


            element = Console.ReadLine();
        }

        foreach (var trainer in trainers.OrderByDescending(a => a.Value.numberOfBadges))
        {
            Console.WriteLine($"{trainer.Key} {trainer.Value.numberOfBadges} {trainer.Value.pokemons.Count}");
        }
    }
}
