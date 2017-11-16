using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GroupByGroup
{
    class GroupByGroup
    {
        static void Main(string[] args)
        {
            var line = Console.ReadLine();

            var students = new List<Person>();
            while (line != "END")
            {
                var tokens = line.Split();
            
                students.Add(new Person(tokens[0] + " "+tokens[1],int.Parse(tokens[2])));

                line = Console.ReadLine();
            }

            var grouped = students.GroupBy(a => a.Group).OrderBy(a => a.Key);

            foreach (var group in grouped)
            {
                Console.Write(group.Key+ " - ");
                var sb = new StringBuilder();
                foreach (var person in group)
                {
                    sb.Append(person.Name).Append(", ");
                }
                sb.Length -= 2;
                Console.WriteLine(sb);
            }
        }
    }

    class Person
    {
        public String Name { get; set; }
        public int Group { get; set; }

        public Person(string name, int group)
        {
            this.Name = name;
            this.Group = group;
        }
    }
}
