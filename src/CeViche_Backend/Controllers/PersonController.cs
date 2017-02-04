using System.Collections.Generic;
using CeViche_Backend.Models;
using Microsoft.AspNetCore.Mvc;

namespace CeViche_Backend.Controllers
{
    [Route("api/[controller]")]
    public class PersonController : Controller
    {
        // GET api/person
        [HttpGet]
        public IEnumerable<Person> GetAllConsultants()
        {
            //Not implemented
            return null;
        }

        // GET api/person/5
        [HttpGet("{id}")]
        public Person GetConsultantById(int id)
        {
            //Not implemented
            return null;
        }

        // POST api/person
        [HttpPost]
        public void AddNewConsultant(Person consultant)
        {
        }

        // PUT api/person/5
        [HttpPut("{id}")]
        public void UpdateConsultant(int id, Person value)
        {
        }

        // DELETE api/person/5
        [HttpDelete("{id}")]
        public void DeleteConsultant(int id)
        {
        }
    }
}
