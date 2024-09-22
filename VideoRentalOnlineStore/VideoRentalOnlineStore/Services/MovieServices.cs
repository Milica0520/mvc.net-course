using Microsoft.AspNetCore.Http.HttpResults;
using VideoRentalOnlineStore.Database;
using VideoRentalOnlineStore.Models.Entities;
using VideoRentalOnlineStore.Models.ViewModels;

namespace VideoRentalOnlineStore.Services
{
    public class MovieServices
    {
       
        public List<MovieVM> GetAllMovies()
        {
            List<MovieVM> moviesToView = InMemoryDB.Movies.Select(m => new MovieVM()
            {
                Id = m.Id,
                Title = m.Title,
                Genre = m.Genre,
                IsAvailable = m.IsAvailable,

            }).ToList();

            return moviesToView;
        }
      


      
    }
}
