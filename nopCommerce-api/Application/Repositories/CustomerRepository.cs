using nopCommerce_api.Application.Repositories.IRepositories;
using nopCommerce_api.Infrastructure.Data;

namespace nopCommerce_api.Application.Repositories
{
    public class CustomerRepository : BaseRepository, ICustomerRepository
    {
        public CustomerRepository(AppDbContext context) : base(context)
        {
        }
    }
}
