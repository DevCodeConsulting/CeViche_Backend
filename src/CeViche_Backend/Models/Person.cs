using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CeViche_Backend.Models
{
    public class Person
    {
        public string Key { get; set; }
        public string Name { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string Summary { get; set; }
        public List<string> Branch { get; set; }
    }
}
