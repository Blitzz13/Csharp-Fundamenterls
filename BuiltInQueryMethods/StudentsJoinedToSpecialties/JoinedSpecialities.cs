using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentsJoinedToSpecialties
{
    class JoinedSpecialities
    {
        static void Main(string[] args)
        {
            var line = Console.ReadLine();
            var specs = new List<StudentsSpecialty>();
            var students = new List<Student>();
            while (line != "Students:")
            {
                var tokens = line.Split();
                specs.Add(new StudentsSpecialty(tokens[0] + " " + tokens[1], int.Parse(tokens[2])));

                line = Console.ReadLine();
            }

            line = Console.ReadLine();
            while (line != "END")
            {
                var tokens = line.Split();
                students.Add(new Student(tokens[1] + " " + tokens[2], int.Parse(tokens[0])));

                line = Console.ReadLine();
            }

            specs.Join(students, sp => sp.FacultyNumber, st => st.FacultyNumber, (sp, st) => new
            {
                Name = st.StudentName,
                FacNum = sp.FacultyNumber,
                Spec = sp.SpecaltyName
            })
                .OrderBy(res => res.Name)
                .ToList()
                .ForEach(res => Console.WriteLine($"{res.Name} {res.FacNum} {res.Spec}"));
        }
    }

    public class StudentsSpecialty
    {
        public string SpecaltyName { get; set; }
        public int FacultyNumber { get; set; }

        public StudentsSpecialty(string specialtyName, int facultyNumber)
        {
            this.SpecaltyName = specialtyName;
            this.FacultyNumber = facultyNumber;
        }
    }

    public class Student
    {
        public string StudentName { get; set; }
        public int FacultyNumber { get; set; }

        public Student(string studentName, int facultyNumber)
        {
            this.StudentName = studentName;
            this.FacultyNumber = facultyNumber;
        }
    }
}
