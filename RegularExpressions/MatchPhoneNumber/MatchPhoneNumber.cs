using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace MatchPhoneNumber
{
    class MatchPhoneNumber
    {
        static void Main(string[] args)
        {
            string pattern = @"^\+359( |-)2\1([0-9]{3,4})\1[0-9]{3,4}$";
            var input = Console.ReadLine();
            while (input != "end")
            {
                if (Regex.Match(input, pattern).Success)
                {
                    Console.WriteLine(input);
                }

                input = Console.ReadLine();
            }
        }
    }
}
