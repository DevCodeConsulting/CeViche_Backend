using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit http://go.microsoft.com/fwlink/?LinkID=397860

namespace CeViche_Backend.Controllers
{
    [Route("api/[controller]")]
    public class ResumeController : Controller
    {
        // GET api/resume/5
        [HttpGet("{consultantId}")]
        public IEnumerable<string> GetAllResumesForConsultant(int consultantId) //Change to IEnumerable<Resume> when available
        {
            //Not implemented
            return null;
        }

        // GET api/resume/5/5
        [HttpGet("{consultantId}/{resumeId}")]
        public string GetAllResumesForConsultant(int consultantId, int resumeId) //Change to Resume when available
        {
            //Not implemented
            return null;
        }

        // POST api/resume
        [HttpPost]
        public void AddNewResume([FromBody]string value)//Change to Resume when available
        {
        }

        // PUT api/resume/5
        [HttpPut("{id}")]
        public void UpdateResume(int id, [FromBody]string value)//Change to Resume when available
        {
        }

        // DELETE api/resume/5
        [HttpDelete("{id}")]
        public void DeleteResume(int id)
        {
        }
    }
}
