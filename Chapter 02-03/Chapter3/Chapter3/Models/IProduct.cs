namespace Chapter3.Models
{
    public interface IProduct
    {
        static abstract bool IsDeliverable { get; }
        void Deliver();
    }
}


