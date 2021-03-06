﻿using System;
using System.Collections.Generic;

namespace CeViche_Backend.Models
{
    public class Person
    {
        public Guid Key { get; set; }
        public string Name { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string Summary { get; set; }
        public List<string> Branch { get; set; }
    }
}
