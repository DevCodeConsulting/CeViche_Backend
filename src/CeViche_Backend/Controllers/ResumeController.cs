using System.Collections.Generic;
using System.Linq;
using CeViche_Backend.Models;
using CeViche_Backend.Repositories;
using Microsoft.AspNetCore.Mvc;
using System;

namespace CeViche_Backend.Controllers
{
    [Route("api/[controller]")]
    public class ResumeController : Controller
    {
        private IResumeRepository ResumeRepository { get; set; }

        public ResumeController(IResumeRepository resumeRepository)
        {
            ResumeRepository = resumeRepository;
        }

        // GET api/resume
        [HttpGet]
        public IEnumerable<Resume> GetAllResumes()
        {
            return ResumeRepository.GetAll();
        }

        // GET api/resume/person/[guid]
        [HttpGet("/person/{personId}")]
        public IEnumerable<Resume> GetAllResumesForSpecificPerson(Guid personId)
        {
            return ResumeRepository.GetAll().Where(x => x.Person.Key == personId);
        }

        // GET api/resume/[guid]
        [HttpGet("{resumeId}")]
        public Resume GetResume(Guid resumeId)
        {
            return ResumeRepository.Find(resumeId);
        }

        // POST api/resume
        [HttpPost]
        public void AddNewResume(Resume resume)
        {
            ResumeRepository.Add(resume);
        }

        // PUT api/resume
        [HttpPut]
        public void UpdateResume(Resume resume)
        {
            ResumeRepository.Update(resume);
        }

        // DELETE api/resume/[guid]
        [HttpDelete("{resumeId}")]
        public void DeleteResume(Guid resumeId)
        {
            ResumeRepository.Remove(resumeId);
        }
    }
}
