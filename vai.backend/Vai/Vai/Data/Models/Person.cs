using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Vai.Data.Models.Enums;

namespace Vai.Data.Models
{
    public class Person
    {
        public Guid Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string MiddleName { get; set; }
        public Gender Gender { get; set; }

        public ICollection<Research> Researches { get; set; }
    }
}
