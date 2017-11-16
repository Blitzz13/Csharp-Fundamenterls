using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Person
{
    //private string company;
    //private string car;
    private List<Parent> _parents = new List<Parent>();
    private List<Child> _children = new List<Child>();
    private List<Pokemon> _pokemons = new List<Pokemon>();
    public Company Company { get; set; }
    public Car Car { get; set; }

    public List<Parent> Parents
    {
        get => _parents;
        set
        {
            _parents = value;
        }
    }

    public List<Child> Children
    {
        get => _children;
        set
        {
            _children = value;
        }
    }
    public List<Pokemon> Pokemons
    {
        get => _pokemons;
        set
        {
            List<Pokemon> children = new List<Pokemon>();
        }
    }
}

