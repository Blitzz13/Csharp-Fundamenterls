using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpinionPoll
{
    class StartUp
    {
        static void Main(string[] args)
        {
            var numberOfPeople = int.Parse(Console.ReadLine());
            var people = new People();
            for (int i = 0; i < numberOfPeople; i++)
            {
                var personInfo = Console.ReadLine().Split();
                var name = personInfo[0];
                var age = int.Parse(personInfo[1]);

                var person = new Person(name, age);
                people.AddPerson(person);
            }

            var oldPeople = people.FindOldestPeople();

            oldPeople.OrderBy(a => a.Name).ToList().ForEach(a => Console.WriteLine($"{a.Name} - {a.Age}"));
        }
    }
}
