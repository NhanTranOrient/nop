using nopCommerce_api.Application.Models;
using nopCommerce_api.Application.Repositories.IRepositories;
using nopCommerce_api.Application.Services.IServices;
using System.Collections.Generic;

namespace nopCommerce_api.Application.Services
{
    public class ProductService : IProductService
    {
        private readonly IProductRepository _productRepository;

        public ProductService(IProductRepository productRepository)
        {
            _productRepository = productRepository;
        }

        public IEnumerable<ProductModel> GetProducts()
        {
            return _productRepository.GetProducts();
        }
    }
}
