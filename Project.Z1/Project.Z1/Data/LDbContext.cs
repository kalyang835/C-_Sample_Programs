using Microsoft.EntityFrameworkCore;
using Project.Z1.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Project.Z1.Data
{
    public class LDbContext:DbContext
    {


        public LDbContext(DbContextOptions<LDbContext> options) : base(options)
        { }
        public DbSet<Leader> Leader { get; set; }



    }
}
