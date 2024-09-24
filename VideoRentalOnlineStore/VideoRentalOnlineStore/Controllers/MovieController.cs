using Microsoft.AspNetCore.Mvc;
using VideoRentalOnlineStore.Database;
using VideoRentalOnlineStore.Models.Entities;
using VideoRentalOnlineStore.Models.ViewModels;
using VideoRentalOnlineStore.Services;

namespace VideoRentalOnlineStore.Controllers
{

    [Route("movie")]
    public class MovieController : Controller
    {
        private readonly MovieServices _movieService;

        private readonly ApplicationDbContext _context;

        public MovieController(ApplicationDbContext context,MovieServices movieServices)
        {
            _context = context;
            _movieService = new MovieServices();
        }

        [HttpGet("allMovies")]
        public IActionResult AllMovies()
        {
            var allMovies = _movieService.GetAllMovies();

            return View(allMovies);
        }

        [HttpGet("details/{id}")]

        public IActionResult MovieDetails(int id)
        {
            var movie = _movieService.GetMovieById(id);
            return View(movie);
        }
    }
}
