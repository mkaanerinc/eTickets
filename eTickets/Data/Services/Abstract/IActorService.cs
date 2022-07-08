using eTickets.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace eTickets.Data.Services.Abstract
{
    public interface IActorService
    {
        Task<IEnumerable<Actor>> GetAllAsync();
        Task<Actor> GetByIdAsync(int actorId);
        Task AddAsync(Actor actor);
        Task<Actor> UpdateAsync(int actorId, Actor newActor);
        Task DeleteAsync(int actorId);
    }
}
