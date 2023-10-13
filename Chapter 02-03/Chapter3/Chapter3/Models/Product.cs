namespace Chapter3.Models
{
    public partial class Product: IProduct
    {
        public Product()
        {
            /* Any custom operation
             * for initialization
             */
        }

        public Product (string title)
        {
            this.Title = title;
        }

        public static bool IsDeliverable => false;

        public int Id { get; set; }
        public string? Title { get; set; }
        public decimal Price { get; set; }

        public void Deliver()
        {
            throw new NotImplementedException();
        }
    }
}



