using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace webdb.Models {
    public class AppDbContext : DbContext 
    {
        public AppDbContext (DbContextOptions<AppDbContext> options) : base(options)
        {

        }
        public DbSet<Vehicle> Vehicles {get; set;}
    }
}