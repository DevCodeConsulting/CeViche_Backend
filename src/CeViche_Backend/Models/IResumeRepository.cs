using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CeViche_Backend.Models
{
    public interface IResumeRepository
    {
        void Add(Resume item);
        IEnumerable<Resume> GetAll();
        Resume Find(string key);
        Resume Remove(string key);
        void Update(Resume resume);
    }
}
