using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentsByAge
{
    class StudentsByAge
    {
        static void Main(string[] args)
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
                .Where(x => int.Parse(x[2]) >= 18 && int.Parse(x[2]) <= 24)
                .ToList()
                .ForEach(x => Console.WriteLine(x[0] + " " + x[1] + " " + x[2]));
        }
    }
}
