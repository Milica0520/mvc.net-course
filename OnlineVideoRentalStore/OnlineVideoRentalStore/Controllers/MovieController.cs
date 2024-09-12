using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Mvc;
using OnlineVideoRentalStore.DataBase;
using OnlineVideoRentalStore.Models.DtoModels;
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
            var findMovie = InMemoryDb.Movies.FirstOrDefault(movie => movie.Title == viewModel.Title);

            if (findMovie != null)
            {
                TempData["Message"] = "Movie with this title already exists.";
                return RedirectToAction("ShowAllMovies");

            }
            else
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


            }

            return RedirectToAction("ShowAllMovies");

        }

        [HttpGet("edit")]


        public IActionResult EditMovie(int movieId)
        {
            var entity = InMemoryDb.Movies.Single(m => m.Id == movieId);

            var viewModel = new CreateMovieVM()
            {
                Id = entity.Id,
                Title = entity.Title,
                Length = entity.Length,
                Genre = entity.Genre,
                Language = entity.Language,
                IsAvailable = entity.IsAvailable,
                AgeRestriction = entity.AgeRestriction,
                Quantity = entity.Quantity,

            };
            return View(viewModel);
        }


        [HttpPost("edit")]

        public IActionResult EditMovie(CreateMovieVM movieVM)
        {
            var entity = InMemoryDb.Movies.Single(m => m.Id == movieVM.Id);

            entity.Title = movieVM.Title;
            entity.Length = movieVM.Length;
            entity.Genre = movieVM.Genre;
            entity.Language = movieVM.Language;
            entity.IsAvailable = movieVM.IsAvailable;
            entity.AgeRestriction = movieVM.AgeRestriction;
            entity.Quantity = movieVM.Quantity;


            InMemoryDb.Save(entity);
            return RedirectToAction("ShowAllMovies");
        }
        [HttpGet("delete")]

        public IActionResult DeleteMovie(int movieId)
        {
            var entity = InMemoryDb.Movies.Single(m => m.Id == movieId);

            var viewModel = new CreateMovieVM()
            {
                Id = entity.Id,
                Title = entity.Title,
                Length = entity.Length,
                Genre = entity.Genre,
                Language = entity.Language,
                IsAvailable = entity.IsAvailable,
                AgeRestriction = entity.AgeRestriction,
                Quantity = entity.Quantity,

            };
            return View(viewModel);
        }


        [HttpPost("delete")]
        public IActionResult DeleteMovie(CreateMovieVM movieVM)
        {
            var entity = InMemoryDb.Movies.Single(m => m.Id == movieVM.Id);

            InMemoryDb.Movies.Remove(entity);

            return RedirectToAction("ShowAllMovies");
        }


        [HttpGet("details")]

        public IActionResult DetailsMovie(int movieId)
        {
            var entity = InMemoryDb.Movies.FirstOrDefault(m => m.Id ==movieId);
          
                var movie = new MovieDetailsVM()
                {
                    Id = entity.Id,
                    Title = entity.Title,
                    Length = entity.Length,
                    Genre = entity.Genre,
                    Language = entity.Language,
                    IsAvailable = entity.IsAvailable,
                    AgeRestriction = entity.AgeRestriction,
                    Quantity = entity.Quantity,

                };
           
            return View(movie);
        }

        [HttpPut("rent")]
        public IActionResult Rent(int id)
        {



            return View();  
        }
    }
}
