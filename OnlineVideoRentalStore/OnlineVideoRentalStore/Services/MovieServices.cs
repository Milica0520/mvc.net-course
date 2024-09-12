using OnlineVideoRentalStore.DataBase;
using OnlineVideoRentalStore.Models.DtoModels;
using OnlineVideoRentalStore.Models.Enteties;

namespace OnlineVideoRentalStore.Services
{
    public class MovieServices
    {


        public List<MovieAllDto> GetAllMovies()
        {

            var movies = InMemoryDb.Movies;

            List<MovieAllDto> allMovies = new List<MovieAllDto>();


            foreach (var movie in movies)
            {
                var movieV = new MovieAllDto()
                {
                    Id = movie.Id,
                    Title = movie.Title,
                    Genre = movie.Genre,
                    Language = movie.Language,
                    ReleaseDate = movie.ReleaseDate,
                    IsAvailable = movie.IsAvailable,
                    Length = movie.Length,
                    AgeRestriction = movie.AgeRestriction,
                };
                allMovies.Add(movieV);
            }

            return allMovies;
        }

       



    }
}
