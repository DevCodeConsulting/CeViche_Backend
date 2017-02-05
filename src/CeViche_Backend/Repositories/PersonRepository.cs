using CeViche_Backend.Models;
using System;
using System.Collections.Concurrent;
using System.Collections.Generic;

namespace CeViche_Backend.Repositories
{
    public class PersonRepository : IPersonRepository
    {
        private static readonly ConcurrentDictionary<Guid, Person> People = new ConcurrentDictionary<Guid, Person>();

        public PersonRepository()
        {

        }

        public void Add(Person person)
        {
            person.Key = Guid.NewGuid();
            People[person.Key] = person;
        }

        public IEnumerable<Person> GetAll()
        {
            return People.Values;
        }

        public Person Find(Guid key)
        {
            Person person;
            People.TryGetValue(key, out person);
            return person;
        }

        public Person Remove(Guid key)
        {
            Person person;
            People.TryRemove(key, out person);
            return person;
        }

        public void Update(Person person)
        {
            People[person.Key] = person;
        }
    }
}
