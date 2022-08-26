using Microsoft.EntityFrameworkCore;

namespace Cart_Example.Models
{
    public class CRContext : DbContext
    {
        public CRContext(DbContextOptions<CRContext> options) : base(options)
        {

        }
        public DbSet<Product> Products { get; set; }
        public DbSet<Cart> carts { get; set; }

        public DbSet<Catogery> catogeries { get; set; }
    }
}
