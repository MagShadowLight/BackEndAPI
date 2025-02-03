namespace WebApplication1.Models
{
    public class Feedback
    {
        public int FeedBackId { get; set; }

        public string Name { get; set; }

        public string Email { get; set; }

        public string Comments { get; set; }

        public Boolean ResponseNeeded { get; set; }
    }
}
