using DIPatternDemo1.Models;
using Microsoft.EntityFrameworkCore;

namespace DIPatternDemo1.Data
{
    public class ApplicationDbContext : DbContext 
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> op) : base(op) 
        {

        }

        public DbSet<Employee>? Empoyees { get; set; }
        public DbSet<Student>? Students { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products { get; set; }


    }


}
