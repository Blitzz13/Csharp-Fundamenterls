using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using DefineAClass;


class StartUp
{
    static void Main(string[] args)
    {
        var numberOfPeople = int.Parse(Console.ReadLine());
        var family = new Family();
        for (int i = 0; i < numberOfPeople; i++)
        {
            var personInfo = Console.ReadLine().Split();
            var name = personInfo[0];
            var age =int.Parse(personInfo[1]);

            var person = new Person(name,age);
            family.AddMember(person);
        }

        var oldestPerson = family.GetOldestMember();

        Console.WriteLine($"{oldestPerson.Name} {oldestPerson.Age}");

    }

}

