using VideoRentalOnlineStore.Database;
using VideoRentalOnlineStore.Models.ViewModels;

namespace VideoRentalOnlineStore.Services
{
    public class MovieServices
    {
       
        public List<MovieVM> GetAllMovies()
        {
            List<MovieVM> moviesToView = InMemoryDB.Movies.Select(m => new MovieVM()
            {
                Title = m.Title,
                Genre = m.Genre,
                IsAvailable = m.IsAvailable,

            }).ToList();

            return moviesToView;
        }
    }
}
