using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CeViche_Backend.Models
{
    public class Resume
    {
        public Guid Key { get; set; }
        public Person Person { get; set; }
        public Competence Competence { get; set; }
        public Education Education { get; set; }
        public Employer Employer { get; set; }
        public string CoverLetter { get; set; }
        public Revision Revision { get; set; }
    }

    public class Revision
    {
        public DateTime Created { get; set; }
        public Person CreatedBy { get; set; }
        public DateTime LastUpdate { get; set; }
        public Person UpdatedBy { get; set; }
    }
}
