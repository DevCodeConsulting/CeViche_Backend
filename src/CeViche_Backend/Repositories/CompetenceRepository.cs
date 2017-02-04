using CeViche_Backend.Models;
using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CeViche_Backend.Repositories
{
    public class CompetenceRepository : ICompetenceRepository
    {
        private static ConcurrentDictionary<Guid, Competence> _competences = new ConcurrentDictionary<Guid, Competence>();

        public CompetenceRepository()
        {
            Add(new Competence { Name = "Test" });
        }

        public void Add(Competence competence)
        {
            competence.Key = Guid.NewGuid();
            _competences[competence.Key] = competence;
        }

        public IEnumerable<Competence> GetAll()
        {
            return _competences.Values;
        }

        public Competence Find(Guid key)
        {
            Competence competence;
            _competences.TryGetValue(key, out competence);
            return competence;
        }

        public Competence Remove(Guid key)
        {
            Competence competence;
            _competences.TryRemove(key, out competence);
            return competence;
        }

        public void Update(Competence competence)
        {
            _competences[competence.Key] = competence;
        }
    }
}
