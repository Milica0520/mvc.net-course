using VideoRentalOnlineStore.Models.Enums;

namespace VideoRentalOnlineStore.Models.ViewModels
{
    public class MovieVM
    {
        public string Title { get; set; }
        public Genre Genre { get; set; }

        public bool IsAvailable { get; set; }

    }
}
