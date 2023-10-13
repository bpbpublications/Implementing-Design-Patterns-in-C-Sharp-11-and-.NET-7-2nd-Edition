namespace Chapter12.Models
{
    public class ContentRepository : IContentRepository
    {

        public List<Content> GetContent()
        {
            List<Content> contentList = new List<Content>();
            List<Advertisement> advertisements = new List<Advertisement>()
        {
            new Advertisement() { Product = "T-Shirt" },
            new Advertisement() { Product = "Energy Drink"},
            new Advertisement() { Product = "Game ticket"}
        };

            Content content1 = new Content();
            content1.News = new News()
            {
                Title = "Football",
                Description = "Sport news description"
            };
            content1.Category = CategoryEnum.Sports;
            content1.Advertisements = advertisements;

            Content content2 = new Content();
            content2.News = new News()
            {
                Title = "Book",
                Description = "Education news description"
            };
            content2.Category = CategoryEnum.Education;
            content2.Advertisements = advertisements;

            Content content3 = new Content();
            content3.News = new News()
            {
                Title = "Lifestyle",
                Description = "Lifestyle news description"
            };
            content3.Category = CategoryEnum.Lifestyle;
            content3.Advertisements = advertisements;

            contentList.Add(content1);
            contentList.Add(content2);
            contentList.Add(content3);

            return contentList;
        }
    }
}


