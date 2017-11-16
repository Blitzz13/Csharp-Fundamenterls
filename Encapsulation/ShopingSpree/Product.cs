using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Product
{
    private string name;
    private double cost;

    public Product(string name, double cost)
    {
        this.Name = name;
        this.Cost = cost;
    }

    public string Name { get; set; }
    public double Cost { get; set; }
}

