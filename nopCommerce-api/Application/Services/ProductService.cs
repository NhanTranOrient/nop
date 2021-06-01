using nopCommerce_api.Application.Models;
using nopCommerce_api.Application.Repositories.IRepositories;
using nopCommerce_api.Application.Services.IServices;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace nopCommerce_api.Application.Services
{
    public class ProductService : IProductService
    {
        private readonly IProductRepository _productRepository;

        public ProductService(IProductRepository productRepository)
        {
            _productRepository = productRepository;
        }

        public Task<ProductModel> GetProductById(int id)
        {
            return _productRepository.GetProductById(id);
        }

        public Task<List<ProductModel>> GetProducts()
        {
            return _productRepository.GetProducts();
        }
    }
}
