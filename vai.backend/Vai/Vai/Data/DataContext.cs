using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Vai.Data.Models;

namespace Vai.Data
{
    public class DataContext : DbContext
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
            builder.Entity<Research>().HasOne(r => r.TestData).WithOne(td => td.Research);

            //many to many relation 
            builder.Entity<Research>().HasMany(r => r.Sports).WithOne(sr => sr.Research);
            builder.Entity<Sport>().HasMany(s => s.Researches).WithOne(sr => sr.Sport);
            //compound key for connecting table
            builder.Entity<SportResearch>().HasKey(sr => new { sr.SportId, sr.ResearchId });

            base.OnModelCreating(builder);
        }
    }
}
