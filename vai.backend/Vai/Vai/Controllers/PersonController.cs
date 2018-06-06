using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Vai.Data;
using Vai.Data.Models;

namespace Vai.Controllers
{
    [Route("api/[controller]")]
    public class PersonController : Controller
    {
        private readonly DataContext dataContext;

        public PersonController(DataContext dataContext)
        {
            this.dataContext = dataContext;
        }

        [HttpGet]
        [Authorize]
        public async Task<IActionResult> Get()
        {
            var persons = await dataContext.Persons.ToArrayAsync();
            return Json(new { result = persons });
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> Get(Guid id)
        {
            if (!ModelState.IsValid) return NotFound();
            var person = await dataContext.Persons
                .Include(p => p.Researches)
                .SingleOrDefaultAsync(p => p.Id == id);
            if (person == null) return NotFound();
            return Json(new { result = person });
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody]string value)
        {
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
