using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormattingNumbers
{
    class FormattingNumbers
    {
        static void Main(string[] args)
        {
            var tokens = Console.ReadLine().Split(new [] {' ','\t'},StringSplitOptions.RemoveEmptyEntries).ToArray();
            var a = int.Parse(tokens[0]);
            var aBinary = Convert.ToString(a, 2);
            double b = double.Parse(tokens[1]);
            double c = double.Parse(tokens[2]);

            if (aBinary.Length > 10)
            {
                aBinary.Remove(10, aBinary.Length - 10);
            }

            Console.WriteLine($"|{a,-10:X}|{aBinary.PadLeft(10,'0')}|{b,10:f2}|{c,-10:f3}|");
        }
    }
}
