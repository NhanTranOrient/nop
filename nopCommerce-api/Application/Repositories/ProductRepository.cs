using nopCommerce_api.Application.Models;
using nopCommerce_api.Application.Repositories.IRepositories;
using nopCommerce_api.Domain.Entities;
using nopCommerce_api.Infrastructure.Data;
using System.Collections.Generic;
using System.Linq;

namespace nopCommerce_api.Application.Repositories
{
    public class ProductRepository : BaseRepository, IProductRepository
    {
        public ProductRepository(AppDbContext context) : base(context)
        {
        }

        public IEnumerable<ProductModel> GetProducts()
        {
            var products = _context.Set<Product>().ToList();
            return products.Select(p => new ProductModel
            {
                Id = p.Id,
                Name = p.Name
            });
        }
    }
}
