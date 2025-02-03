namespace WebApplication1.Models
{
    public class Category
    {
        public int CategoryId { get; set; }

        public string Name { get; set; }

        public virtual ICollection<Category> Categories { get; set; }

    }
}