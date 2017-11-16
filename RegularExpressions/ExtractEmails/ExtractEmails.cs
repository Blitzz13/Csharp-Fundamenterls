using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ExtractEmails
{
    class ExtractEmails
    {
        static void Main(string[] args)
        {
            var pattern = @"[A-Za-z0-9][\w\.\-]@[a-zA-Z\d][\w\.\-\d]+";

            var input = Console.ReadLine();

            var matches = Regex.Matches(input, pattern);

            foreach (var match in matches)
            {
                Console.WriteLine(match.ToString());
            }
        }
    }
}
