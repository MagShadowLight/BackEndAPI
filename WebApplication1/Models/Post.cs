namespace WebApplication1.Models
{
    public class Post
    {

        public int PostID { get; set; }
        public string Title { get; set; }
        public string Body { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime UpdatedDate { get; set; }
        public string Author { get; set; }
        public VisibilityStatus Visibitity { get; set; }

        // FK
        public int CategoryId { get; set; }
        // related data
        public Category Category { get; set; }

    }
}
