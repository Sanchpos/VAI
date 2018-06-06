using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Vai.Data.Models.Authorization
{
    public class User : IdentityUser
    {
        [ForeignKey(nameof(Person))]
        public Guid PersonId { get; set; }
        public Person Person { get; set; }
    }
}
