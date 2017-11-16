using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace SeriesOfLetters
{
    class SeriesOfLetters
    {
        static void Main(string[] args)
        {
            var pattern = @"([A-Za-z])\1+";
            var input = Console.ReadLine();

            Console.WriteLine(Regex.Replace(input, pattern, "$1"));
           
        }
    }
}
