namespace Chapterr9.Models
{
    public class PostPaidMobilePlan : IMobilePlan
    {
        public IConnectionSpeed ConnectionSpeed { get; set; }
        public ITextMessage TextMessage { get; set; }

        public void PostPaidIntegration()
        {

        }
    }
}


