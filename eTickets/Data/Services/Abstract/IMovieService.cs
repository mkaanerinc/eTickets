using eTickets.Data.BaseService;
using eTickets.Data.ViewModels;
using eTickets.Models;
using System.Threading.Tasks;

namespace eTickets.Data.Services.Abstract
{
    public interface IMovieService : IEntityBaseRepository<Movie>
    {
        Task<Movie> GetMovieByIdAsync(int movieId);
        Task<MovieDropdownsVM> GetNewMovieDropdownsValues();
        Task AddNewMovieAsync(MovieVM data);
        Task UpdateMovieAsync(MovieVM data);
    }
}
