using CeViche_Backend.Models;
using System;
using System.Collections.Concurrent;
using System.Collections.Generic;

namespace CeViche_Backend.Repositories
{
    public class CompetenceRepository : ICompetenceRepository
    {
        private static readonly ConcurrentDictionary<Guid, Competence> Competences = new ConcurrentDictionary<Guid, Competence>();

        public CompetenceRepository()
        {
            Add(new Competence { Name = "Test" });
        }

        public void Add(Competence competence)
        {
            competence.Key = Guid.NewGuid();
            Competences[competence.Key] = competence;
        }

        public IEnumerable<Competence> GetAll()
        {
            return Competences.Values;
        }

        public Competence Find(Guid key)
        {
            Competence competence;
            Competences.TryGetValue(key, out competence);
            return competence;
        }

        public Competence Remove(Guid key)
        {
            Competence competence;
            Competences.TryRemove(key, out competence);
            return competence;
        }

        public void Update(Competence competence)
        {
            Competences[competence.Key] = competence;
        }
    }
}
