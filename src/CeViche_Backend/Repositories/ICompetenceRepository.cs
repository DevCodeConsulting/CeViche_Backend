using CeViche_Backend.Models;
using System;
using System.Collections.Generic;

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
