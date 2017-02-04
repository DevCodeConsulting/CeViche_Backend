using CeViche_Backend.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CeViche_Backend.Repositories
{
    public interface IEducationRepository
    {
        void Add(Education education);
        IEnumerable<Education> GetAll();
        Education Find(Guid key);
        Education Remove(Guid key);
        void Update(Education education);
    }
}
