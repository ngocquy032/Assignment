using Microsoft.EntityFrameworkCore;

namespace ShoppingCart.Models
{
    public class ProductDBContext : DbContext
    {
        public ProductDBContext()
        {
        }

        public ProductDBContext(DbContextOptions<ProductDBContext> options)
            : base(options)
        {
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=LAPTOP-QG7K8HCB\\SQLEXPRESS;Initial Catalog=T2208M_Movie;Persist Security Info=True;User ID=sa;Password=241403;Encrypt=False");
        }

        public DbSet<Product> Products { get; set; }
      
    }
}
