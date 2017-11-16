using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FilterStudentsByPhone
{
    class FilterByPhone
    {
        static void Main(string[] args)
        {
            var line = Console.ReadLine();
            var list = new List<string>();
            while (line != "END")
            {
                var tokens = line.Split();
                var number = tokens[2];
                if (number.Substring(0,5) == "+3592" || number.Substring(0,2) == "02")
                {
                    list.Add(tokens.First() + " " + tokens.Skip(1).First());
                }
                line = Console.ReadLine();
            }
            list.ForEach(Console.WriteLine);
        }
    }
}
