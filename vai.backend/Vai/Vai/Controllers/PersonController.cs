using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
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
        public IEnumerable<Person> Get()
        {
            return dataContext.Persons.ToList();
        }

        [HttpGet("{id}")]
        public IActionResult Get(Guid id)
        {
            if (!ModelState.IsValid) return NotFound();
            var person = dataContext.Persons.Include(p => p.Researches);
            return Json(person);
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
