using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace MatchFullName
{
    class MatchFullName
    {
        static void Main(string[] args)
        {
            string pattern = "^[A-Z][a-z]+ [A-Z][a-z]+$";
            var input = Console.ReadLine();
            while (input != "end")
            {
                if (Regex.Match(input,pattern).Success)
                {
                    Console.WriteLine(input);
                }

                input = Console.ReadLine();
            }
        }
    }
}
