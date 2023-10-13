namespace Chapter12.Models
{
    public class Content
    {
        public int Id { get; set; }
        public News News { get; set; }
        public List<Advertisement> Advertisements { get; set; } = new List<Advertisement>();
        public CategoryEnum Category { get; set; }

    }

    public enum CategoryEnum
    {
        Sports = 1,
        Technology = 2,
        Health = 3,
        Lifestyle = 4,
        Education = 5
    }
}

