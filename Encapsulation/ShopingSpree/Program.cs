using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Program
{
    static void Main(string[] args)
    {
        var humans = Console.ReadLine().Split(new[] { ';' }, StringSplitOptions.RemoveEmptyEntries);
        List<Person> people = new List<Person>();

        for (int i = 0; i < humans.Length; i++)
        {
            try
            {
                var human = humans[i].Split(new[] { '=' }, StringSplitOptions.RemoveEmptyEntries);
                var person = new Person(human[0], double.Parse(human[1]));
                people.Add(person);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        var inputProducts = Console.ReadLine().Split(new[] { ';' }, StringSplitOptions.RemoveEmptyEntries);
        List<Product> products = new List<Product>();

        for (int i = 0; i < inputProducts.Length; i++)
        {
            try
            {
                var productArgs = inputProducts[i].Split(new[] { '=' }, StringSplitOptions.RemoveEmptyEntries);
                var product = new Product(productArgs[0], double.Parse(productArgs[1]));
                products.Add(product);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        var line = Console.ReadLine().Split();
        while (line[0] != "END")
        {
            try
            {
                var person = people.FirstOrDefault(a => a.Name == line[0]);
                var product = products.FirstOrDefault(a => a.Name == line[1]);
                if (person.Money >= product.Cost)
                {
                    person.Money -= product.Cost;
                    person.AddProductInThebag(product.Name);
                }
                else
                {
                    Console.WriteLine($"{person.Name} can't afford {product.Name}");
                }
            }
            catch
            {
            }

            line = Console.ReadLine().Split();
        }

        foreach (var person in people)
        {
            if (person.BagOfProducts.Count < 1)
            {
                Console.WriteLine($"{person.Name} – Nothing bought");
            }
            else
            {
                Console.WriteLine($"{person.Name} - {string.Join(", ", person.BagOfProducts)}");
            }
        }
    }
}
