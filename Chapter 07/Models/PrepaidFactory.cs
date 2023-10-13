namespace Chapter7.Models
{
    public class PrepaidFactory: IMobilePlanFactory
    {
        public IConnectionSpeedFactory CreateConnectionSpeed()
        {
            return new LowSpeed();
        }

        public IMobileDataFactory CreateMobileData()
        {
            return new TenGigabytes();
        }

        public ITextMessageFactory CreateTextMessage()
        {
            return new ThousandTextMessage();
        }
    }
}
