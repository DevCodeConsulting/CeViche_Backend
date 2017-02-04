using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CeViche_Backend.Models
{
    interface IEmployerRepository
    {
        void Add(Employer employer);
        IEnumerable<Employer> GetAll();
        Employer Find(string key);
        Employer Remove(string key);
        void Update(Employer employer);
    }
}
