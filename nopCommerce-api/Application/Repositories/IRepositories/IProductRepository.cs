using nopCommerce_api.Application.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace nopCommerce_api.Application.Repositories.IRepositories
{
    public interface IProductRepository
    {
        Task<List<ProductModel>> GetProducts();

        Task<ProductModel> GetProductById(int id);
    }
}
