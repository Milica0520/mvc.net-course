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

        [HttpGet("details/{id}")]

        public IActionResult MovieDetails(int id)
        {
            var entity = InMemoryDB.Movies.Where(m => m.Id == id).FirstOrDefault();


            if (entity == null)
            {
                return NotFound();  
            }
            var movie = new MovieDetailsVM()
            {
               
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
        

       
    }
}
