using CeViche_Backend.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CeViche_Backend.Repositories
{
    public interface IResumeRepository
    {
        void Add(Resume item);
        IEnumerable<Resume> GetAll();
        Resume Find(Guid key);
        Resume Remove(Guid key);
        void Update(Resume resume);
    }
}
