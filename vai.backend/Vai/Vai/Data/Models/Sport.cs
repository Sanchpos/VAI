﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Vai.Data.Models
{
    public class Sport
    {
        public Guid Id { get; set; }

        public string Name { get; set; }

        public ICollection<SportResearch> Researches { get; set; }
    }
}
