using Microsoft.EntityFrameworkCore;
using WebAPIdemo.Models;

namespace WebAPIdemo.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> option) : base(option)
        {

        }

        public DbSet<Product> Products { get; set; }
        public DbSet<Employee> Employees { get; set; }



    }
}
