using nopCommerce_api.Application.Models;
using System.Collections.Generic;

namespace nopCommerce_api.Application.Repositories.IRepositories
{
    public interface IProductRepository
    {
        IEnumerable<ProductModel> GetProducts();
    }
}
