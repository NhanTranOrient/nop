using nopCommerce_api.Application.Models;
using System.Collections.Generic;

namespace nopCommerce_api.Application.Services.IServices
{
    public interface IProductService
    {
        IEnumerable<ProductModel> GetProducts();
    }
}
