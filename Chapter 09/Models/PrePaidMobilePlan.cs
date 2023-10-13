namespace Chapterr9.Models
{
    public class PrePaidMobilePlan : IMobilePlan
    {
        public IConnectionSpeed ConnectionSpeed { get; set; }
        public ITextMessage TextMessage { get; set; }

        public void PrePaidIntegrtion()
        {

        }
    }
}

