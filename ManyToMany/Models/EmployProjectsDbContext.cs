using Microsoft.EntityFrameworkCore;

namespace ManyToMany.Models
{
    public class EmployProjectsDbContext:DbContext
    {
        public EmployProjectsDbContext(DbContextOptions<EmployProjectsDbContext> options):base(options)
        {
            
        }

        public DbSet<Employe> employes { get; set; }

        public DbSet<Project> projects { get; set; }
    }
}
