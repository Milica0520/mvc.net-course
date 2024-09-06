namespace OnlineVideoRentalStore.Models.Enteties
{
    public class User
    {
        public int Id { get; set; }
        public string UserName { get; set; }

        public string Email { get; set; }
        public int Age { get; set; }
        public string CardNumber { get; set; }
        public DateTime CreatedOn { get; set; }
  
        public bool IsSubscriptionExpired { get; set; }
        public string SubscriptionType { get; set; }
    }
}
