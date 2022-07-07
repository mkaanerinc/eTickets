using eTickets.Data;
using eTickets.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Threading.Tasks;

namespace eTickets.Controllers
{
    public class MoviesController : Controller
    {
        private readonly AppDbContext _context;

        public MoviesController(AppDbContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> Index()
        {
            var listOfMovies = await _context.Set<Movie>()
                .Include(x => x.Cinema)
                .OrderBy(x => x.Name)
                .ToListAsync();

            return View(listOfMovies);
        }
    }
}
