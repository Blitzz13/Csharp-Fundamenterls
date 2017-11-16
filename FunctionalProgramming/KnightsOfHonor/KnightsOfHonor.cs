using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KnightsOfHonor
{
    class KnightsOfHonor
    {
        static void Main(string[] args)
        {
            Action<string> printer = n => Console.WriteLine("Sir "+n);
            var input = Console.ReadLine();
            input.Split(new [] {' ','\t'},StringSplitOptions.RemoveEmptyEntries).ToList().ForEach(printer);
        }
    }
}
