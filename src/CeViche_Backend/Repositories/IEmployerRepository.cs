﻿using CeViche_Backend.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CeViche_Backend.Repositories
{
    public interface IEmployerRepository
    {
        void Add(Employer employer);
        IEnumerable<Employer> GetAll();
        Employer Find(Guid key);
        Employer Remove(Guid key);
        void Update(Employer employer);
    }
}
