using System.Collections.Generic;
using CeViche_Backend.Models;
using Microsoft.AspNetCore.Mvc;

namespace CeViche_Backend.Controllers
{
    [Route("api/[controller]")]
    public class CompetenceController : Controller
    {
        // GET api/competence
        [HttpGet]
        public IEnumerable<Competence> GetAllCompetences()
        {
            //Not implemented
            return null;
        }

        // GET api/competence/5
        [HttpGet("{id}")]
        public Competence GetCompetence(int id)
        {
            //Not implemented
            return null;
        }

        // POST api/competence
        [HttpPost]
        public void AddNewCompetence(Competence competence)
        {
        }

        // PUT api/competence/5
        [HttpPut("{id}")]
        public void UpdateCompetence(int id, Competence value)
        {
        }

        // DELETE api/competence/5
        [HttpDelete("{id}")]
        public void DeleteCompetence(int id)
        {
        }
    }
}
