using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using Vai.Data.Models.Authorization;
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

        [ForeignKey(nameof(UserId))]
        public User User { get; set; }
        public Guid UserId { get; set; }

        public ICollection<Research> Researches { get; set; }
    }
}
