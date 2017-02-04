using CeViche_Backend.Models;
using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CeViche_Backend.Repositories
{
    public class ResumeRepository : IResumeRepository
    {
        private static ConcurrentDictionary<Guid, Resume> _resumes = new ConcurrentDictionary<Guid, Resume>();

        public ResumeRepository()
        {

        }

        public void Add(Resume resume)
        {
            resume.Key = Guid.NewGuid();
            _resumes[resume.Key] = resume;
        }

        public IEnumerable<Resume> GetAll()
        {
            return _resumes.Values;
        }

        public Resume Find(Guid key)
        {
            Resume resume;
            _resumes.TryGetValue(key, out resume);
            return resume;
        }

        public Resume Remove(Guid key)
        {
            Resume resume;
            _resumes.TryRemove(key, out resume);
            return resume;
        }

        public void Update(Resume resume)
        {
            _resumes[resume.Key] = resume;
        }
    }
}
