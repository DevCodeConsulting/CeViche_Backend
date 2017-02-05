using System;

namespace CeViche_Backend.Models
{
    public class Education
    {
        public Guid Key { get; set; }
        public string Name { get; set; }
        public string School { get; set; }
        public string Degree { get; set; }
    }
}
