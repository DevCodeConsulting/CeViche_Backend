using System;

namespace CeViche_Backend.Models
{
    public class Competence
    {
        public Guid Key { get; set; }
        public string Name { get; set; }
        public string Category { get; set; }
        public string SkillLevel { get; set; }
    }
}
