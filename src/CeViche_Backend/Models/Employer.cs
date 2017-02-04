using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CeViche_Backend.Models
{
    public class Employer
    {
        public Guid Key { get; set; }
        public string Name { get; set; }
        public List<string> Branch { get; set; }
        public List<string> Technique { get; set; }
    }
}
