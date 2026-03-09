namespace SustainabilityPlatform.Model
{
    public class Notification
    {
        public int Id { get; set; }

        public int AlertId { get; set; }

        public int? UserId { get; set; }
        public string Channel { get; set; }

        public DateTime? ReadAt { get; set; }

        public Alert Alert { get; set; }

        public User User { get; set; }
    }
}
