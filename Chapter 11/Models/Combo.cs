namespace DesignPatternsBookChapter11.Models
{
    public class Combo : IProduct
    {

        private List<IProduct> _subProducts;
        public Combo()
        {
            _subProducts = new List<IProduct>();
        }

        #region PROPERTIES
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public string Category { get; set; }
        #endregion
        public void GetProductDetails()
        {
            Console.WriteLine($"Name:{Name}.  Category: {Category}");

            Console.WriteLine("****All the products in this combo****");

            foreach (var subProduct in _subProducts)
            {
                subProduct.GetProductDetails();
            }
        }

        public decimal GetProductPrice()
        {
            this.Price = 0;

            foreach (var subProduct in _subProducts)
            {
                this.Price += subProduct.GetProductPrice();
            }

            Console.WriteLine($"***Total Price: {this.Price}***");
            return this.Price;
        }
        public void AddProduct(IProduct product)
        {
            _subProducts.Add(product);
        }
        public void RemoveProduct(IProduct product)
        {
            _subProducts.Remove(product);
        }
    }

}
