using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CeViche_Backend.Models
{
    public interface IPersonRepository
    {
        void Add(Person item);
        IEnumerable<Person> GetAll();
        Person Find(string key);
        Person Remove(string key);
        void Update(Person person);
    }
}
