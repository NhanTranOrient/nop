using nopCommerce_api.Application.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace nopCommerce_api.Application.Services.IServices
{
    public interface IProductService
    {
        Task<List<ProductModel>> GetProducts();

        Task<ProductModel> GetProductById(int id);
    }
}
