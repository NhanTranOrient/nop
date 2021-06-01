using nopCommerce_api.Application.Repositories.IRepositories;
using nopCommerce_api.Domain.Entities;
using nopCommerce_api.Infrastructure.Data;

namespace nopCommerce_api.Application.Repositories
{
    public class CustomerRepository : EfCoreRepository<IEntity>, ICustomerRepository
    {
        public CustomerRepository(AppDbContext context) : base(context)
        {
        }
    }
}
