using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class Pokemon
{
    private string pokeName;
    public string element;
    public double health;

    public Pokemon(string pokeName, string element, double health)
    {
        this.pokeName = pokeName;
        this.element = element;
        this.health = health;
    }
}