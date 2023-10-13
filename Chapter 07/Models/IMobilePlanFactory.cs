namespace Chapter7.Models
{
    public interface IMobilePlanFactory
    {
        ITextMessageFactory CreateTextMessage();
        IConnectionSpeedFactory CreateConnectionSpeed();
        IMobileDataFactory CreateMobileData();
    }
}


