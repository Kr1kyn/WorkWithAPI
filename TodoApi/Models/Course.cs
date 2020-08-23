﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TodoApi.Models
{
    public class Course
    {
        public int Id { get; set; }
        public string Course_Name { get; set; }
        public IEnumerable<Lection> Lections { get; set; }
    }
}
