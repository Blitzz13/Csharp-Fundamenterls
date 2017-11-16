using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReverseAndExclude
{
    class ReverseAndExclude
    {
        static void Main(string[] args)
        {
            var list = Console.ReadLine().Split().Select(int.Parse).ToList();
            int number = int.Parse(Console.ReadLine());

            list = list.Where(a => a % number != 0).Reverse().ToList();

            Console.WriteLine(string.Join(" ", list));
        }
    }
}
