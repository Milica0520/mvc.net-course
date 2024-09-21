using VideoRentalOnlineStore.Models.Entities;
using VideoRentalOnlineStore.Models.Enums;


namespace VideoRentalOnlineStore.Database
{
    public static class InMemoryDB
    {
        public static List<Movie> Movies = new List<Movie>
        {
            new Movie
            {
                Id = 1,
                Title = "Inception",
                Genre = Genre.SciFi,
                Language = Language.English,
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
                Genre = Genre.Drama,
                Language = Language.Korean,
                IsAvailable = true,
                ReleaseDate = new DateTime(2019, 5, 30),
                Length = new TimeSpan(2, 12, 0),
                AgeRestriction = 15,
                Quantity = 3
            },
            new Movie
            {
                Id = 3,
                Title = "The Dark Knight",
                Genre = Genre.Action,
                Language = Language.English,
                IsAvailable = false,
                ReleaseDate = new DateTime(2008, 7, 18),
                Length = new TimeSpan(2, 32, 0),
                AgeRestriction = 13,
                Quantity = 0
            },
            new Movie
            {
                Id = 4,
                Title = "Spirited Away",
                Genre = Genre.Animated,
                Language = Language.Japanese,
                IsAvailable = true,
                ReleaseDate = new DateTime(2001, 7, 20),
                Length = new TimeSpan(2, 5, 0),
                AgeRestriction = 10,
                Quantity = 4
            },
            new Movie
            {
                Id = 5,
                Title = "La La Land",
                Genre = Genre.Musical,
                Language = Language.English,
                IsAvailable = true,
                ReleaseDate = new DateTime(2016, 12, 9),
                Length = new TimeSpan(2, 8, 0),
                AgeRestriction = 13,
                Quantity = 2
            }
        };
    }
}

