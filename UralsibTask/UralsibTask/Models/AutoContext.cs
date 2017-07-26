using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace UralsibTask.Models
{
    public class AutoContext : DbContext
    {
        public DbSet<Brand> Brands { get; set; }
        public DbSet<Marcs> Marcs { get; set; }
    }
}