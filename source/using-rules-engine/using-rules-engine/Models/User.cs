﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    internal class User
    {
        public int Id { get; set; }
        public string? Name { get; set; }

        public IEnumerable<Certificate>? Certificates { get; set; }
    }
}
