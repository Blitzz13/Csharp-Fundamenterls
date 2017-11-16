using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpinionPoll
{
    class People
    {
        private List<Person> people;

        //people = new List<Person>();

        public void AddPerson(Person person)
        {
            this.people.Add(person);
        }

        public List<Person> FindOldestPeople()
        {
            return this.people.Where(a => a.Age > 30).ToList();
        }

        public People()
        {
            this.people = new List<Person>();
        }
    }
}
