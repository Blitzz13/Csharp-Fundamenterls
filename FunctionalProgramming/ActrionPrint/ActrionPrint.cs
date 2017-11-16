using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ActrionPrint
{
    class ActrionPrint
    {
        static void Main(string[] args)
        {
            Action<string> printer = n => Console.WriteLine(n);
            var input = Console.ReadLine();
            input.Split().ToList().ForEach(n => Console.WriteLine(n));
        }
    }
}
