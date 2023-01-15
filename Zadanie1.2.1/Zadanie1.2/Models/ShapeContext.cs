using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Zadanie1._2.Models
{
    public class ShapeContext : DbContext
    {
        public DbSet<Shape> Shapes { get; set; }
        public DbSet<Organization> Organizations { get; set; }

        public ShapeContext(DbContextOptions<ShapeContext> options)
            : base(options)
        {
            Database.EnsureCreated();
        }

    }
}
