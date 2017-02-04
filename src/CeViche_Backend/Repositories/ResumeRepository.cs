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
        private static ConcurrentDictionary<string, Resume> _resumes = new ConcurrentDictionary<string, Resume>();

        public ResumeRepository()
        {

        }

        public void Add(Resume resume)
        {
            resume.Key = Guid.NewGuid().ToString();
            _resumes[resume.Key] = resume;
        }

        public IEnumerable<Resume> GetAll()
        {
            return _resumes.Values;
        }

        public Resume Find(string key)
        {
            Resume resume;
            _resumes.TryGetValue(key, out resume);
            return resume;
        }

        public Resume Remove(string key)
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
