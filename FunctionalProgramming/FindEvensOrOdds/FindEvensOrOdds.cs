using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindEvensOrOdds
{
    class FindEvensOrOdds
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split(new[] { ' ', '\t' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse).ToList();
            var evenOrOdd = Console.ReadLine();
            var list = new List<int>();
            for (int i = input[0]; i <= input[1]; i++)
            {
                list.Add(i);
            }
            if (evenOrOdd == "even")
            {
                Console.WriteLine(string.Join(" ",list.Where(a => a % 2 == 0)));
            }
            else
            {
                Console.WriteLine(string.Join(" ", list.Where(a => a % 2 != 0)));
            }
        }
    }
}
