using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Vai.Data.Models.Authorization
{
    public class User : IdentityUser<Guid>
    {
        [ForeignKey(nameof(PersonId))]
        public Person Person { get; set; }
        public Guid? PersonId { get; set; }
    }
}
