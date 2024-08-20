using OnlineVideoRentalStore.Models.Enteties;

namespace OnlineVideoRentalStore.DataBase
{
    public static class InMemoryDb
    {

        public static List<Movie> Movies = new List<Movie>(); 

        static InMemoryDb()
        {
            LoadMoviesDb();
        }

        private static void LoadMoviesDb()
        {

           Movies = new List<Movie>
        {
            new Movie
            {
                Id = 1,
                Title = "Inception",
                Genre = "Sci-Fi",
                Language = "English",
                IsAvailable = true,
                ReleaseDate = new DateTime(2010, 7, 16),
                Length = new TimeSpan(2, 28, 0),
                AgeRestriction = 13,
                Quantity = 5
            },
            new Movie
            {
                Id = 2,
                Title = "Parasite",
                Genre = "Thriller",
                Language = "Korean",
                IsAvailable = true,
                ReleaseDate = new DateTime(2019, 5, 30),
                Length = new TimeSpan(2, 12, 0),
                AgeRestriction = 16,
                Quantity = 3
            },
            new Movie
            {
                Id = 3,
                Title = "The Godfather",
                Genre = "Crime",
                Language = "English",
                IsAvailable = false,
                ReleaseDate = new DateTime(1972, 3, 24),
                Length = new TimeSpan(2, 55, 0),
                AgeRestriction = 18,
                Quantity = 2
            },
            new Movie
            {
                Id = 4,
                Title = "Spirited Away",
                Genre = "Animation",
                Language = "Japanese",
                IsAvailable = true,
                ReleaseDate = new DateTime(2001, 7, 20),
                Length = new TimeSpan(2, 5, 0),
                AgeRestriction = 8,
                Quantity = 4
            },
            new Movie
            {
                Id = 5,
                Title = "The Dark Knight",
                Genre = "Action",
                Language = "English",
                IsAvailable = true,
                ReleaseDate = new DateTime(2008, 7, 18),
                Length = new TimeSpan(2, 32, 0),
                AgeRestriction = 13,
                Quantity = 6
            }
        };
        }



}
}
