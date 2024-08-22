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
        [HttpGet("edit")]
        public IActionResult EditMovie(int movieId)
        {
            var entity = InMemoryDb.Movies.Single(m=> m.Id == movieId);

            var viewModel = new CreateMovieVM()
            {
                Id = entity.Id,
                Title = entity.Title,
                Length = entity.Length,

            };


            return View(viewModel);
        }
        [HttpPost("edit")]
        public IActionResult EditMovie(CreateMovieVM movieVM)
        {
            var entity = InMemoryDb.Movies.Single(m => m.Id == movieVM.Id);

            entity.Title = movieVM.Title;
            entity.Length = movieVM.Length;

            InMemoryDb.Save(entity);



         


            return RedirectToAction("ShowAllMovies");
        }


    }
}
