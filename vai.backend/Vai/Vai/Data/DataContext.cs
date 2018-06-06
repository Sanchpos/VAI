using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Vai.Data.Models;
using Vai.Data.Models.Authorization;

namespace Vai.Data
{
    public class DataContext : IdentityDbContext
    {
        public DbSet<Person> Persons { get; set; }
        public DbSet<Research> Researches { get; set; }
        public DbSet<TestsData> Tests { get; set; }

        public DataContext(DbContextOptions options): base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<Person>().HasMany(p => p.Researches).WithOne(r => r.Person);
            builder.Entity<Research>().HasOne(r => r.TestDataInternal).WithOne(td => td.Research);

            //many to many relation 
            builder.Entity<Research>().HasMany(r => r.Sports).WithOne(sr => sr.Research);
            builder.Entity<Sport>().HasMany(s => s.Researches).WithOne(sr => sr.Sport);
            //compound key for connecting table
            builder.Entity<SportResearch>().HasKey(sr => new { sr.SportId, sr.ResearchId });

            builder.Entity<User>().HasOne(u => u.Person).WithOne(p => p.User);

            base.OnModelCreating(builder);
        }
    }
}
