using System.Collections.Generic;
using System.Threading.Tasks;

namespace eTickets.Data.BaseService
{
    public interface IEntityBaseRepository<T> where T : class, IEntityBase, new()
    {
        Task<IEnumerable<T>> GetAllAsync();
        Task<T> GetByIdAsync(int entityId);
        Task AddAsync(T entity);
        Task UpdateAsync(int entityId, T entity);
        Task DeleteAsync(int entityId);
    }
}
