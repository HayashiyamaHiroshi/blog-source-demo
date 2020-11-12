using Microsoft.EntityFrameworkCore;
using IncludeStudy.Models;

namespace IncludeStudy.Models
{
    public class DemoContext : DbContext
    {

        public DemoContext(DbContextOptions<DemoContext> opt) : base(opt)
        {
            
        }

        public DemoContext()
        {
            
        }

        public DbSet<IncludeStudy.Models.Company> Company { get; set; }
        public DbSet<IncludeStudy.Models.Employee> Employee { get; set; }
    }
}