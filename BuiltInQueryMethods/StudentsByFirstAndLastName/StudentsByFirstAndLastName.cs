using System;
using System.Collections.Generic;
using System.Linq;

namespace StudentsByFirstAndLastName
{
    class StudentsByFirstAndLastName
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            var names = new List<string>();
            while (input != "END")
            {
                string[] inputArgs = input.Split();

                if (string.Join(" ", inputArgs.OrderBy(a => a)).Equals(input))
                {
                    names.Add(input);
                }

                input = Console.ReadLine();
            }

            Console.WriteLine(string.Join("\n",names));
        }
    }
}
