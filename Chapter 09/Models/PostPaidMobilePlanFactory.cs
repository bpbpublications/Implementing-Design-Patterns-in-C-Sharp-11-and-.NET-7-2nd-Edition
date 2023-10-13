namespace Chapterr9.Models
{
    public class PostPaidMobilePlanFactory : BaseMobilePlanFactory
    {
        public override IMobilePlan CreateMobilePlan()
        {
            PostPaidMobilePlan prePaidMobilePlan = new PostPaidMobilePlan();

            prePaidMobilePlan.ConnectionSpeed = new ConnectionSpeed()
            {
                Name = "High Connection Speed",
                Velocity = 100
            };

            prePaidMobilePlan.TextMessage = new TextMessage()
            {
                Name = "PostPaid Text Message",
                QuantityPerMonth = 5000
            };

            prePaidMobilePlan.PostPaidIntegration();

            return prePaidMobilePlan;

        }

    }
}

