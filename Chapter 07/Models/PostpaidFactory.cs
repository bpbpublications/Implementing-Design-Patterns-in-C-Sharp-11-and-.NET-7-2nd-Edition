namespace Chapter7.Models
{
    public class PostpaidFactory: IMobilePlanFactory
    {
        public IConnectionSpeedFactory CreateConnectionSpeed()
        {
            return new HighSpeed();
        }

        public IMobileDataFactory CreateMobileData()
        {
            return new UnlimitedMobileData();
        }

        public ITextMessageFactory CreateTextMessage()
        {
            return new UnlimitedTexxtMessage();
        }
    }
}


