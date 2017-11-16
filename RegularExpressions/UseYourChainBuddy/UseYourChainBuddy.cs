using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace UseYourChainBuddy
{
    class UseYourChainBuddy
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine();

            var matches = Regex.Matches(input, "<p>(.*?)<\\/p>");

            foreach (Match match in matches)
            {
                var whiteSpaces = @"[^a-z0-9]";
                var reminder = match.Groups[1].Value;
                var replaced = Regex.Replace(reminder, whiteSpaces, " ");
                var pattern = @"\s+";
                replaced = Regex.Replace(replaced, pattern, " ");
                foreach (var character in replaced)
                {
                    if (character >= 'a' && character <= 'm')
                    {
                        Console.Write((char)(character + 13));
                        
                    }
                    else if (character >= 'n' && character <= 'z')
                    {
                        Console.Write((char)(character - 13));
                    }
                    else
                    {
                        Console.Write(character);
                    }
                }
            }
        }
    }
}
