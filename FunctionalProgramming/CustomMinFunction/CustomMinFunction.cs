using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomMinFunction
{
    class CustomMinFunction
    {
        static void Main(string[] args)
        {
            Func<string, int> parser = n => int.Parse(n);
            var input = Console.ReadLine();
           
            var arr = input.Split(new[] { ' ', '\t' }, StringSplitOptions.RemoveEmptyEntries).Select(parser).ToList().OrderBy(a => a);
            Console.WriteLine(arr.First());
        }

    }
}
