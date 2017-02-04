using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CeViche_Backend.Models
{
    interface IEducationRepository
    {
        void Add(Education education);
        IEnumerable<Education> GetAll();
        Education Find(string key);
        Education Remove(string key);
        void Update(Education education);
    }
}
