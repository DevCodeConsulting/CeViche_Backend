using CeViche_Backend.Models;
using System;
using System.Collections.Concurrent;
using System.Collections.Generic;

namespace CeViche_Backend.Repositories
{
    public class ResumeRepository : IResumeRepository
    {
        private static readonly ConcurrentDictionary<Guid, Resume> Resumes = new ConcurrentDictionary<Guid, Resume>();

        public ResumeRepository()
        {

        }

        public void Add(Resume resume)
        {
            resume.Key = Guid.NewGuid();
            Resumes[resume.Key] = resume;
        }

        public IEnumerable<Resume> GetAll()
        {
            return Resumes.Values;
        }

        public Resume Find(Guid key)
        {
            Resume resume;
            Resumes.TryGetValue(key, out resume);
            return resume;
        }

        public Resume Remove(Guid key)
        {
            Resume resume;
            Resumes.TryRemove(key, out resume);
            return resume;
        }

        public void Update(Resume resume)
        {
            Resumes[resume.Key] = resume;
        }
    }
}
