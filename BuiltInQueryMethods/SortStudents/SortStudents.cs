using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortStudents
{
    class SortStudents
    {
        static void Main(string[] args)
        {
            var line = Console.ReadLine();
            var list = new List<string[]>();
            while (line != "END")
            {
                var tokens = line.Split();
                list.Add(tokens);
                line = Console.ReadLine();
            }

            list.OrderBy(a => a[1]).ThenByDescending(a => a[0]).ToList().ForEach(a => Console.WriteLine(a[0] + " " + a[1]));


        }
    }
}
