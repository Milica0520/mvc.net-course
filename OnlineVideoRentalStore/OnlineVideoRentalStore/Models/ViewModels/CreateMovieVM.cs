using System.ComponentModel.DataAnnotations;

namespace OnlineVideoRentalStore.Models.ViewModels
{
    public class CreateMovieVM
    {
        public int Id { get; set; }

        [Required]
        public string Title { get; set; }
        [Required]
        public string Genre { get; set; }
        [Required]
        public string Language { get; set; }
        [Required]
        public bool IsAvailable { get; set; }
         [Required]
        public DateTime ReleaseDate { get; set; }
        [Required]
        public TimeSpan Length { get; set; }
        [Required]
        public int AgeRestriction { get; set; }
        [Required]
        public int Quantity { get; set; }
    }
}
