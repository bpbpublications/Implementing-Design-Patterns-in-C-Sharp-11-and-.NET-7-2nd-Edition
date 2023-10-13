namespace DesignPatternsBookChapter11.Models
{
    public interface IProduct
    {
        int Id { get; set; }
        string Name { get; set; }
        decimal Price { get; set; }
        string Category { get; set; }
        void GetProductDetails();
        decimal GetProductPrice();
    }
}


