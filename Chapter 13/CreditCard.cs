namespace DesignPatternsBookChapter13
{
    public class CreditCard
    {
        public int Id { get; set; }
        public string Number { get; set; }
        public string HolderName { get; set; }
        public DateTime ExpirationDate { get; set; }
        public int SecurityCode { get; set; }
    }
}
