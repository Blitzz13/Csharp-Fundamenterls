using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SetsOfElements
{
    class SetsOfElements
    {
        static void Main(string[] args)
        {
            var tokens = Console.ReadLine().Split().Select(int.Parse).ToArray();

            var setN = new HashSet<double>();
            var setM = new HashSet<double>();

            for (int i = 0; i < tokens[0]; i++)
            {
                var number = double.Parse(Console.ReadLine());
                setN.Add(number);
            }

            for (int i = 0; i < tokens[1]; i++)
            {
                var number = double.Parse(Console.ReadLine());
                setM.Add(number);
            }

            foreach (var element in setN.Intersect(setM))
            {
                Console.Write($"{element} ");
            }
        }
    }
}
