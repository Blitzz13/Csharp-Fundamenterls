using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomComparator
{
    class CustomComparator
    {
        static void Main(string[] args)
        {
            var arr = Console.ReadLine().Split().Select(int.Parse).ToArray();

            var oddList = arr.Where(a => a % 2 != 0).OrderBy(a => a).ToList();
            var evenList = arr.Where(a => a % 2 == 0).OrderBy(a => a).ToList();

            evenList.AddRange(oddList);

            Console.WriteLine(String.Join(" ",evenList));
        }
    }
}
