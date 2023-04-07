using Microsoft.EntityFrameworkCore;

namespace LaptopProject.Models
{
    public class LaptopDbContext : DbContext
    {
        public LaptopDbContext(DbContextOptions<LaptopDbContext> options) : base(options)
        {
        }

        public DbSet<Laptop> Laptops { get; set; }
    }
}
