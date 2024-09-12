namespace OnlineVideoRentalStore.Models.DtoModels
{
    public class MovieAllDto
    {
        public int Id { get; set; }

        public string Title { get; set; }

        public string Genre { get; set; }

        public string Language { get; set; }

        public DateTime ReleaseDate { get; set; }

        public bool IsAvailable { get; set; }
        public TimeSpan Length { get; set; }

        public int AgeRestriction { get; set; }

        public int Quantity { get; set; }
    }
}
