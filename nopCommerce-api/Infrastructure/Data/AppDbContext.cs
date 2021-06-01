using Microsoft.EntityFrameworkCore;
using nopCommerce_api.Domain.Entities;

namespace nopCommerce_api.Infrastructure.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        { }

        public DbSet<Product> Product { get; set; }
    }
}
