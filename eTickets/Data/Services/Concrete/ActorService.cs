using eTickets.Data.BaseService;
using eTickets.Data.Services.Abstract;
using eTickets.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace eTickets.Data.Services.Concrete
{
    public class ActorService : EntityBaseRepository<Actor>, IActorService
    {
        public ActorService(AppDbContext appDbContext) : base(appDbContext)
        {
        }
    }
}
