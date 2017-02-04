using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CeViche_Backend.Models
{
    public class PersonRepository : IPersonRepository
    {
        private static ConcurrentDictionary<string, Person> _people = new ConcurrentDictionary<string, Person>();

        public PersonRepository()
        {

        }

        public void Add(Person person)
        {
            person.Key = Guid.NewGuid().ToString();
            _people[person.Key] = person;
        }

        public IEnumerable<Person> GetAll()
        {
            return _people.Values;
        }

        public Person Find(string key)
        {
            Person person;
            _people.TryGetValue(key, out person);
            return person;
        }

        public Person Remove(string key)
        {
            Person person;
            _people.TryRemove(key, out person);
            return person;
        }

        public void Update(Person person)
        {
            _people[person.Key] = person;
        }
    }
}
