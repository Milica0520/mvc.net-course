using Microsoft.AspNetCore.Mvc;
using OnlineVideoRentalStore.DataBase;
using OnlineVideoRentalStore.Models.Enteties;
using OnlineVideoRentalStore.Models.ViewModels;
using OnlineVideoRentalStore.Services;

namespace OnlineVideoRentalStore.Controllers
{

    [Route("movies")]
    public class MovieController : Controller
    {

        private MovieServices _movieService;

        public MovieController()
        {
            _movieService = new MovieServices();
        }


        [HttpGet("all")]

        public ActionResult ShowAllMovies()
        {
            var movies = _movieService.GetAllMovies();

            return View(movies);
        }

        [HttpGet("create")]
        public ActionResult CreateMovie()
        {
            return View("CreateMovie");
        }

        [HttpPost("create")]
        public IActionResult CreateMovie(CreateMovieVM viewModel)
        {
            var entity = new Movie()
            {
                Id = InMemoryDb.Movies.Count + 1,
                Title = viewModel.Title,
                Genre = viewModel.Genre,
                Language = viewModel.Language,
                Length = viewModel.Length,
                IsAvailable = viewModel.IsAvailable,
                AgeRestriction = viewModel.AgeRestriction,
                Quantity = viewModel.Quantity,  
                ReleaseDate = viewModel.ReleaseDate,


            };

            InMemoryDb.Movies.Add(entity);

           
            return RedirectToAction("ShowAllMovies");
        }


    }
}
