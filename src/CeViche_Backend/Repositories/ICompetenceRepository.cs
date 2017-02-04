using CeViche_Backend.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CeViche_Backend.Repositories
{
    public interface ICompetenceRepository
    {
        void Add(Competence item);
        IEnumerable<Competence> GetAll();
        Competence Find(Guid key);
        Competence Remove(Guid key);
        void Update(Competence competence);
    }
}
