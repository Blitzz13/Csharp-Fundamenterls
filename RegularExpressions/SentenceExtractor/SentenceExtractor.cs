using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace SentenceExtractor
{
    class SentenceExtractor
    {
        static void Main(string[] args)
        {
            var keyword = Console.ReadLine();
            var sentence = Console.ReadLine();

            var pattern = $@"[a-zA-Z0-9 ]+\b{keyword}\b\s*.*?[.!?]";

            var matches = Regex.Matches(sentence, pattern);

            foreach (Match match in matches)
            {
                Console.WriteLine(match.Groups[0]);
            }
        }
    }
}
