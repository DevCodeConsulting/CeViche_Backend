using System.Collections.Generic;
using CeViche_Backend.Models;
using Microsoft.AspNetCore.Mvc;
using CeViche_Backend.Repositories;

namespace CeViche_Backend.Controllers
{
    [Route("api/[controller]")]
    public class CompetenceController : Controller
    {
        private ICompetenceRepository CompetenceRepository { get; set; }

        public CompetenceController(ICompetenceRepository competenceRepository)
        {
            CompetenceRepository = competenceRepository;
        }

        // GET api/competence
        [HttpGet]
        public IEnumerable<Competence> GetAllCompetences()
        {
            return CompetenceRepository.GetAll();
        }

        // GET api/competence/[guid]
        [HttpGet("{id}")]
        public Competence GetCompetence(string id)
        {
            return CompetenceRepository.Find(id);
        }

        // POST api/competence
        [HttpPost]
        public void AddNewCompetence(Competence competence)
        {
            CompetenceRepository.Add(competence);
        }

        // PUT api/competence
        [HttpPut]
        public void UpdateCompetence(Competence competence)
        {
            CompetenceRepository.Update(competence);
        }

        // DELETE api/competence/[guid]
        [HttpDelete("{id}")]
        public void DeleteCompetence(string id)
        {
            CompetenceRepository.Remove(id);
        }
    }
}
