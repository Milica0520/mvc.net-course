using Microsoft.AspNetCore.Http.HttpResults;
using VideoRentalOnlineStore.Database;
using VideoRentalOnlineStore.Models.Entities;
using VideoRentalOnlineStore.Models.ViewModels;

namespace VideoRentalOnlineStore.Services
{
    public class MovieServices
    {
        public MovieServices() { }
        private readonly ApplicationDbContext _context;

        public MovieServices(ApplicationDbContext context)
        {
            _context = context;
        }

     

        public List<MovieVM> GetAllMovies()
        {
            List<MovieVM> moviesToView = _context.Movies.Select(m => new MovieVM()
            {
                Id = m.Id,
                Title = m.Title,
                Genre = m.Genre,
                IsAvailable = m.IsAvailable,

            }).ToList();

            return moviesToView;
        }
      public MovieDetailsVM GetMovieById(int id)
        {

            var entity = _context.Movies.Where(m => m.Id == id).FirstOrDefault();


            if (entity == null)
            {
                throw new Exception("Movie not found");
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

            return movie;

        }


      
    }
}
