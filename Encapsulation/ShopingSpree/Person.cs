using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Person
{
    private string name;
    private double money;
    private List<string> bagOfProducts;

    public Person(string name, double money)
    {
        this.Name = name;
        this.Money = money;
        this.bagOfProducts = new List<string>();
    }


    public string Name
    {
        get { return this.name; }
        set
        {
            if (string.IsNullOrEmpty(value))
            {
                throw new ArgumentException($"{nameof(Name)} cannot be empty");
            }

            name = value;
        }
    }

    public double Money
    {
        get { return this.money; }
        set
        {
            if (value < 0)
            {
                throw new ArgumentException($"{nameof(Money)} cannot be negative");
            }

            money = value;
        }
    }

    public List<string> BagOfProducts
    {
        get { return this.bagOfProducts; }
    }

    public void AddProductInThebag(string nameOfProduct)
    {
        this.bagOfProducts.Add(nameOfProduct);
    }
}

