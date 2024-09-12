using OnlineVideoRentalStore.Models.Enteties;

namespace OnlineVideoRentalStore.DataBase
{
    public static class InMemoryDb
    {

        public static List<Movie> Movies = new List<Movie>();

        public static List<User> Users = new List<User>();

        public static List<Rental> Rentals = new List<Rental>(); 
  
        static InMemoryDb()
        {
            LoadMoviesDb();
            LoadUsersDb();
            LoadRentals();
        }

        private static void LoadRentals()
        {
           Rentals = new List<Rental> {
           
           new Rental{ Id = 1, MovieId = 2, UserId = 3, RentedOn = new DateTime(2023, 1, 15), ReturnedOn= new DateTime().AddDays(14) }
           
           };
        }

        private static void LoadUsersDb()
        {
             Users = new List<User>
            {
                new User { Id = 1, UserName = "MarkoM25", Age = 25, CardNumber = "1234567890123456", CreatedOn = new DateTime(2023, 1, 15), IsSubscriptionExpired = false, SubscriptionType = "Monthly", Email = "markom25@example.com" },
                new User { Id = 2, UserName = "AnaAni30", Age = 30, CardNumber = "2345678901234567", CreatedOn = new DateTime(2022, 5, 22), IsSubscriptionExpired = true, SubscriptionType = "Yearly", Email = "anaani30@example.com" },
                new User { Id = 3, UserName = "IvanI40", Age = 40, CardNumber = "3456789012345678", CreatedOn = new DateTime(2021, 10, 10), IsSubscriptionExpired = false, SubscriptionType = "Monthly", Email = "ivani40@example.com" },
                new User { Id = 4, UserName = "PetraP22", Age = 22, CardNumber = "4567890123456789", CreatedOn = new DateTime(2023, 6, 5), IsSubscriptionExpired = false, SubscriptionType = "Yearly", Email = "petrap22@example.com" },
                new User { Id = 5, UserName = "NikNik35", Age = 35, CardNumber = "5678901234567890", CreatedOn = new DateTime(2020, 3, 18), IsSubscriptionExpired = true, SubscriptionType = "Monthly", Email = "niknik35@example.com" },
                new User { Id = 6, UserName = "JelJel27", Age = 27, CardNumber = "6789012345678901", CreatedOn = new DateTime(2023, 8, 1), IsSubscriptionExpired = false, SubscriptionType = "Yearly", Email = "jeljel27@example.com" },
                new User { Id = 7, UserName = "SteSte19", Age = 19, CardNumber = "7890123456789012", CreatedOn = new DateTime(2023, 2, 28), IsSubscriptionExpired = false, SubscriptionType = "Monthly", Email = "steste19@example.com" },
                new User { Id = 8, UserName = "MajaMaj45", Age = 45, CardNumber = "8901234567890123", CreatedOn = new DateTime(2019, 12, 30), IsSubscriptionExpired = true, SubscriptionType = "Yearly", Email = "majmaj45@example.com" },
                new User { Id = 9, UserName = "FilFil50", Age = 50, CardNumber = "9012345678901234", CreatedOn = new DateTime(2022, 11, 3), IsSubscriptionExpired = true, SubscriptionType = "Monthly", Email = "filfil50@example.com" },
                new User { Id = 10, UserName = "SaraSar29", Age = 29, CardNumber = "0123456789012345", CreatedOn = new DateTime(2023, 4, 10), IsSubscriptionExpired = false, SubscriptionType = "Yearly", Email = "sarasar29@example.com" }
                };

        }

        public static void Save(Movie entity)
        {
            var result = Movies.Single(m => m.Id == entity.Id);
            result = entity;
        }

        public static void SaveUser(User entity)
        {
            var result = Users.Single(u => u.Id == entity.Id);
            result = entity;
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
