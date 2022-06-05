using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;

namespace BlogApiDemo.DataAccessLayer
{
    public class Context:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server=DESKTOP-2GOA1TF;database=CoreBlogApiDb; integrated security=true;");
        }
        public DbSet <Employee> Employees { get; set; }
    }
}
