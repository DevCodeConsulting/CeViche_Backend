using System.Collections.Generic;
using CeViche_Backend.Models;
using Microsoft.AspNetCore.Mvc;
using CeViche_Backend.Repositories;

namespace CeViche_Backend.Controllers
{
    [Route("api/[controller]")]
    public class PersonController : Controller
    {
        private IPersonRepository PersonRepository { get; set; }

        public PersonController(IPersonRepository personRepository)
        {
            PersonRepository = personRepository;
        }

        // GET api/person
        [HttpGet]
        public IEnumerable<Person> GetAllPersons()
        {
            return PersonRepository.GetAll();
        }

        // GET api/person/[guid]
        [HttpGet("{id}")]
        public Person GetConsultantById(string id)
        {
            return PersonRepository.Find(id);
        }

        // POST api/person
        [HttpPost]
        public void AddNewConsultant(Person person)
        {
            PersonRepository.Add(person);
        }

        // PUT api/person
        [HttpPut]
        public void UpdateConsultant(Person person)
        {
            PersonRepository.Update(person);
        }

        // DELETE api/person/[guid]
        [HttpDelete("{id}")]
        public void DeleteConsultant(string id)
        {
            PersonRepository.Remove(id);
        }
    }
}
