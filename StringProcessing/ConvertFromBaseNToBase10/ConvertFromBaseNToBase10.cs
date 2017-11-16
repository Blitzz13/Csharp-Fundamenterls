using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace ConvertFromBaseNToBase10
{
    class ConvertFromBaseNToBase10
    {
        static void Main(string[] args)
        {
            BigInteger[] tokens = Console.ReadLine().Split().Select(BigInteger.Parse).ToArray();
            BigInteger basenumber = tokens[0];
            BigInteger number = tokens[1];

            BigInteger theNewBaseNumber = 0;
            int letercount = number.ToString().Length;
            BigInteger c = 0;
            BigInteger b = 1;
            for (int i = 0; i < letercount; i++)
            {
                BigInteger lastNumber = number % 10;
                c = c + (lastNumber * b);
                b *= basenumber;
                number /= 10;
            }
            Console.WriteLine(c);
        }
    }
}
