using Microsoft.EntityFrameworkCore;
using nopCommerce_api.Application.Models;
using nopCommerce_api.Application.Repositories.IRepositories;
using nopCommerce_api.Domain.Entities;
using nopCommerce_api.Infrastructure.Data;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace nopCommerce_api.Application.Repositories
{
    public class ProductRepository : EfCoreRepository<Product>, IProductRepository
    {
        public ProductRepository(AppDbContext context) : base(context)
        {
        }

        public Task<ProductModel> GetProductById(int id)
        {
            var product = GetAll()
                .Where(p => p.Id == id)
                .Select(p => new ProductModel
                {
                    Id = p.Id,
                    Name = p.Name
                }).FirstOrDefaultAsync();

            return product;
        }

        public Task<List<ProductModel>> GetProducts()
        {
            var products = GetAll()
                .Select(p => new ProductModel
                {
                    Id = p.Id,
                    Name = p.Name
                }).ToListAsync();

            return products;
        }
    }
}
