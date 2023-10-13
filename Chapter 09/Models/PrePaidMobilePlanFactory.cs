namespace Chapterr9.Models
{
    public class PrePaidMobilePlanFactory : BaseMobilePlanFactory
    {
        public override IMobilePlan CreateMobilePlan()
        {
            PrePaidMobilePlan prePaidMobilePlan = new PrePaidMobilePlan();

            prePaidMobilePlan.ConnectionSpeed = new ConnectionSpeed()
            {
                Name = "Low Connection Speed",
                Velocity = 50
            };

            prePaidMobilePlan.TextMessage = new TextMessage()
            {
                Name = "PrePaid Text Message",
                QuantityPerMonth = 2000
            };

            prePaidMobilePlan.PrePaidIntegrtion();

            return prePaidMobilePlan;

        }

    }
}

