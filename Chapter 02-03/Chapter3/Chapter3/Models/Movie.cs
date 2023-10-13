namespace Chapter3.Models
{
    public class Movie : IProduct
    {
        public static bool IsDeliverable => false;

        public DateTime ReleaseDate { get; set; }
        public string Category { get; set; }
        public int Duration { get; set; }

 
        public void Deliver()
        {
            //Any custom implementation for the Deliver method
        }
    }
}






