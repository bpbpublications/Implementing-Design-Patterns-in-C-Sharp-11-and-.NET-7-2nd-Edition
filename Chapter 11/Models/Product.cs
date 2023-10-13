namespace DesignPatternsBookChapter11.Models
{
    public class Product: IProduct
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public string Category { get; set; }

        public void GetProductDetails()
        {
            Console.WriteLine($"Name:{Name}. Price: {Price}. Category: {Category}");
        }

        public decimal GetProductPrice()
        {
            return this.Price;
        }
    }
}


