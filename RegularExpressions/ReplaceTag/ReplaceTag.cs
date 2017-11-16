using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ReplaceTag
{
    class ReplaceTag
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine();
            string pattern = (@"<a (href=.+?)>(.+)<\/a>");

            var sb = new StringBuilder();
            while (input != "end")
            {

                sb.AppendLine(input);

                input = Console.ReadLine();
            }
            var result = Regex.Replace(sb.ToString(), pattern, a => $"[URL {a.Groups[1]}]{a.Groups[2]}[/URL]");

            Console.WriteLine(result);
        }
    }
}
