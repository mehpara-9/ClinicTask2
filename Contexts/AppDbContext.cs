using Clinictask.Models;
using Microsoft.EntityFrameworkCore;

namespace Clinictask.Contexts
{

    public class AppDbContext:DbContext
    {
    public DbSet<Healthcareolution>HealthCareSolutions { get; set; }
        public DbSet<Category> Category { get; set; }
       public DbSet<Service> Service { get; set; }

        public AppDbContext(DbContextOptions options):base(options)
        {
            
        }
    }
}
