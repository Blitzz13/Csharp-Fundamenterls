using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UniqueUsernames
{
    class UniqueUsernames
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            var set = new HashSet<string>();

            for (int i = 0; i < n; i++)
            {
                string input = Console.ReadLine();
                set.Add(input);
            }

            foreach (var name in set)
            {
                Console.WriteLine(name);
            }
        }
    }
}
