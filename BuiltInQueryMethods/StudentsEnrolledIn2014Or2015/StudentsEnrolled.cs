using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentsEnrolledIn2014Or2015
{
    class StudentsEnrolled
    {
        static void Main(string[] args)
        {
            var line = Console.ReadLine();
            var students = new List<string>();
            while (line != "END")
            {
                var tokens = line.Split();
                var facultyNumber = tokens.First();

                if (facultyNumber.Substring(facultyNumber.Length - 2,2) == "14" || facultyNumber.Substring(facultyNumber.Length - 2, 2) == "15")
                {
                    students.Add(string.Join(" ", tokens.Skip(1)));
                }

                line = Console.ReadLine();
            }

            students.ForEach(Console.WriteLine);
        }
    }
}
