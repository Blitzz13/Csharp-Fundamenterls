using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FilterStudentsByEmailDomain
{
    class FilterEmails
    {
        static void Main()
        {
            var line = Console.ReadLine();
            var list = new List<string>();
            while (line != "END")
            {
                var tokens = line.Split('@');

                if (tokens.Skip(1).First() == "gmail.com")
                {
                    tokens = line.Split();
                    string name = tokens.First() + " " + tokens.Skip(1).First();
                    list.Add(name);
                }

                line = Console.ReadLine();
            }

            list.ForEach(Console.WriteLine);
        }
    }
}
