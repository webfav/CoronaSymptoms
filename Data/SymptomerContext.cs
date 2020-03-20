using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using CoronaSymptoms.Models;

namespace CoronaSymptoms.Data
{
    public class SymptomerContext : DbContext
    {
        public SymptomerContext(DbContextOptions<SymptomerContext> options)
    : base(options)
        {
        }

        public DbSet<Symptomer> Symptomer { get; set; }
        //public DbSet<Region> Region { get; set; }
    }
}
