using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentsByGroup
{
    class StudentsByGroup
    {
        static void Main()
        {
            string input = Console.ReadLine();
            var students = new List<string[]>();
            while (input != "END")
            {
                string[] inputArgs = input.Split();

                students.Add(inputArgs);
                input = Console.ReadLine();
            }

            students
                .Where(x => x[2].Equals("2"))
                .OrderBy(x => x[0])
                .ToList()
                .ForEach(x => Console.WriteLine(x[0] + " " + x[1]));
        }
    }
}
