using Microsoft.AspNetCore.Mvc;
using nopCommerce_api.Domain.Entities;
using nopCommerce_api.Infrastructure.Data;
using System.Collections.Generic;
using System.Linq;

namespace nopCommerce_api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly AppDbContext _context;
        public ProductController(AppDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public IEnumerable<Product> GetProducts()
        {
            var products = _context.Set<Product>().ToList();
            return products;
        }
    }
}
