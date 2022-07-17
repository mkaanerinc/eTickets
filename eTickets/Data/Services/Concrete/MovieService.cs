using eTickets.Data.BaseService;
using eTickets.Data.Services.Abstract;
using eTickets.Data.ViewModels;
using eTickets.Models;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Threading.Tasks;

namespace eTickets.Data.Services.Concrete
{
    public class MovieService : EntityBaseRepository<Movie>, IMovieService
    {
        private readonly AppDbContext _context;
        public MovieService(AppDbContext appDbContext) : base(appDbContext)
        {
            _context = appDbContext;
        }

        public async Task AddNewMovieAsync(MovieVM data)
        {
            var newMovie = new Movie()
            {
                Name = data.Name,
                Description = data.Description,
                Price = data.Price,
                ImageUrl = data.ImageUrl,
                CinemaId = data.CinemaId,
                StartDate = data.StartDate,
                EndDate = data.EndDate,
                MovieCategory = data.MovieCategory,
                ProducerId = data.ProducerId
            };

            await _context.Set<Movie>().AddAsync(newMovie);
            await _context.SaveChangesAsync();

            // Add Movie Actors

            foreach (var actorId in data.ActorIds)
            {
                var newActorMovie = new Actor_Movie()
                {
                    MovieId = newMovie.Id,
                    ActorId = actorId
                };

                await _context.Set<Actor_Movie>().AddAsync(newActorMovie);
            }
            await _context.SaveChangesAsync();
        }

        public async Task<Movie> GetMovieByIdAsync(int movieId)
        {
            var movieDetails = await _context.Set<Movie>()
                .Include(x => x.Cinema)
                .Include(x => x.Producer)
                .Include(x => x.Actors_Movies).ThenInclude(x => x.Actor)
                .FirstOrDefaultAsync(x => x.Id == movieId);

            return movieDetails;
        }

        public async Task<MovieDropdownsVM> GetNewMovieDropdownsValues()
        {
            var result = new MovieDropdownsVM()
            {
                Actors = await _context.Set<Actor>()
                .OrderBy(x => x.FullName).ToListAsync(),

                Cinemas = await _context.Set<Cinema>()
                .OrderBy(x => x.Name).ToListAsync(),

                Producers = await _context.Set<Producer>()
                .OrderBy(x => x.FullName).ToListAsync()
            };

            return result;
        }

        public async Task UpdateMovieAsync(MovieVM data)
        {
            var dbMovie = await _context.Set<Movie>().FirstOrDefaultAsync(x => x.Id == data.Id);

            if (dbMovie != null)
            {
                dbMovie.Name = data.Name;
                dbMovie.Description = data.Description;
                dbMovie.Price = data.Price;
                dbMovie.ImageUrl = data.ImageUrl;
                dbMovie.CinemaId = data.CinemaId;
                dbMovie.StartDate = data.StartDate;
                dbMovie.EndDate = data.EndDate;
                dbMovie.MovieCategory = data.MovieCategory;
                dbMovie.ProducerId = data.ProducerId;
                await _context.SaveChangesAsync();
            }

            // Remove existing actors

            var existingActorDb = _context.Set<Actor_Movie>().Where(x => x.MovieId == data.Id).ToList();
            _context.Set<Actor_Movie>().RemoveRange(existingActorDb);
            await _context.SaveChangesAsync();

            // Add Movie Actors

            foreach (var actorId in data.ActorIds)
            {
                var newActorMovie = new Actor_Movie()
                {
                    MovieId = data.Id,
                    ActorId = actorId
                };

                await _context.Set<Actor_Movie>().AddAsync(newActorMovie);
            }
            await _context.SaveChangesAsync();
        }
    }
}
