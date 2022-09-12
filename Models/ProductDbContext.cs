using Microsoft.EntityFrameworkCore;

namespace DotnetCoreMVCapp.Models
{
    public class ProductDbContext:DbContext
    {
        public ProductDbContext(DbContextOptions<ProductDbContext> options) : base(options)
        {}            
        public DbSet<Product> Products { get; set; }
        
    }
}
