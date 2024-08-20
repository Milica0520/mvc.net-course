using Microsoft.AspNetCore.Mvc;
using OnlineVideoRentalStore.Services;

namespace OnlineVideoRentalStore.Controllers
{
    public class MovieController : Controller
    {

        private MovieServices _movieService;

        public MovieController()
        {
            _movieService = new MovieServices();
        }
        public IActionResult ShowAllMovies()
        {
            var movies = _movieService.GetAllMovies();

            return Json(movies);
        }
    }
}
