using eTickets.Data.Services.Abstract;
using eTickets.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace eTickets.Data.Services.Concrete
{
    public class ActorService : IActorService
    {
        private readonly AppDbContext _context;

        public ActorService(AppDbContext appDbContext)
        {
            _context = appDbContext;
        }
        public async Task AddAsync(Actor actor)
        {
            await _context.Set<Actor>().AddAsync(actor);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteAsync(int actorId)
        {
            var result = await _context.Set<Actor>().FirstOrDefaultAsync(x => x.Id == actorId);
            _context.Set<Actor>().Remove(result);
            await _context.SaveChangesAsync();
        }

        public async Task<IEnumerable<Actor>> GetAllAsync()
        {
            var result = await _context.Set<Actor>().ToListAsync();

            return result;
        }

        public async Task<Actor> GetByIdAsync(int actorId)
        {
            var result = await _context.Set<Actor>().FirstOrDefaultAsync(x => x.Id == actorId);
            return result;
        }

        public async Task<Actor> UpdateAsync(int actorId, Actor newActor)
        {
            _context.Update(newActor);
            await _context.SaveChangesAsync();
            return newActor;
        }
    }
}
