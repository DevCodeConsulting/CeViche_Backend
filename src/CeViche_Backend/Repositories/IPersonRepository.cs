using CeViche_Backend.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CeViche_Backend.Repositories
{
    public interface IPersonRepository
    {
        void Add(Person item);
        IEnumerable<Person> GetAll();
        Person Find(Guid key);
        Person Remove(Guid key);
        void Update(Person person);
    }
}
