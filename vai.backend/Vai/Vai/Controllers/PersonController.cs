using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Vai.Data;
using Vai.Data.Models;
using Vai.Data.Models.Authorization;
using Vai.Services;

namespace Vai.Controllers
{
    [Route("api/[controller]")]
    public class PersonController : Controller
    {
        private readonly DataContext dataContext;
        //private readonly UserManager<User> _userManager;
        private readonly IAuthorizationService _authorizationService;

        public PersonController(DataContext dataContext, IAuthorizationService authorizationService)
        {
            this.dataContext = dataContext;
            _authorizationService = authorizationService;
        }

        [Authorize]
        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var persons = await dataContext.Persons.ToArrayAsync();
            return Json(new { result = persons });
        }

        [Authorize]
        [HttpGet("{id}")]
        public async Task<IActionResult> Get(Guid id)
        {
            if (!ModelState.IsValid) return NotFound();
            var person = await dataContext.Persons
                .Include(p => p.Researches)
                .SingleOrDefaultAsync(p => p.Id == id);
            if (person == null) return NotFound();

            var authResult = await _authorizationService.AuthorizeAsync(User, person, Operations.Read);
            if (authResult.Succeeded)
            {
                return Json(new { result = person });
            } else
            {
                return Forbid();
            }
        }

        //[Authorize(Roles = "staff")]
        //[HttpPost]
        //public async Task<IActionResult> Post([Bind(
        //    nameof(Person.FirstName),
        //    nameof(Person.LastName),
        //    nameof(Person.MiddleName),
        //    nameof(Person.Gender))]Person value)
        //{
        //    if (!ModelState.IsValid) return NotFound();
        //    //some role checks
        //    _userManager.
        //}

        [HttpPut("{id}")]
        public void Put(int id, [FromBody]string value)
        {
        }

        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
