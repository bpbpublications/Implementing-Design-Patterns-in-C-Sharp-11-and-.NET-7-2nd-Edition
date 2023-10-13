namespace Chapter3.Models
{
    public partial class Product
    {
        public virtual void ApplyDiscount()
        {
            this.Price = Decimal.Multiply(this.Price, (7 / 100));
        }
    }
}


