using eTickets.Data.BaseService;
using eTickets.Data.Services.Abstract;
using eTickets.Models;

namespace eTickets.Data.Services.Concrete
{
    public class CinemaService : EntityBaseRepository<Cinema>, ICinemaService
    {
        public CinemaService(AppDbContext appDbContext) : base(appDbContext)
        {

        }
    }
}
