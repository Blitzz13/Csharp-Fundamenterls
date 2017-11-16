using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PredicateForNames
{
    class PredicateForNames
    {
        static void Main(string[] args)
        {
            int lenght = int.Parse(Console.ReadLine());

            var list = Console.ReadLine();
            list.Split().Where(a => a.Length <= lenght).ToList().ForEach(a => Console.WriteLine(a));
        }
    }
}
