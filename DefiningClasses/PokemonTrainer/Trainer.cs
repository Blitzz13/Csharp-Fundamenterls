using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class Trainer
{
    private string name;
    public int numberOfBadges;
    public List<Pokemon> pokemons;

    public Trainer(string name)
    {
        this.name = name;
        this.pokemons = new List<Pokemon>();
        this.numberOfBadges = 0;
    }

    public void AddPokemon(Pokemon pokemon)
    {
        this.pokemons.Add(pokemon);
    }
}

