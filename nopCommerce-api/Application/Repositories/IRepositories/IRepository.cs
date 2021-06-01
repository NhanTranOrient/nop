using nopCommerce_api.Domain.Entities;
using System.Linq;
using System.Threading.Tasks;

namespace nopCommerce_api.Application.Repositories.IRepositories
{
    public interface IRepository<T> where T : class, IEntity
    {
        IQueryable<T> GetAll();
        Task<T> Get(int id);
        Task<T> Add(T entity);
        Task<T> Update(T entity);
        Task<T> Delete(int id);
    }
}
