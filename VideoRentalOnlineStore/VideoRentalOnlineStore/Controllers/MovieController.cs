using Microsoft.AspNetCore.Mvc;
using VideoRentalOnlineStore.Database;

using VideoRentalOnlineStore.Models.ViewModels;
using VideoRentalOnlineStore.Services;

namespace VideoRentalOnlineStore.Controllers
{

    [Route("movie")]
    public class MovieController : Controller
    {
        private MovieServices _movieService;

        public MovieController()
        {
            _movieService = new MovieServices();
        }
        [HttpGet("allMovies")]   
        public IActionResult AllMovies()
        {
           var allMovies = _movieService.GetAllMovies();

            return View(allMovies);
        }
    }
}
