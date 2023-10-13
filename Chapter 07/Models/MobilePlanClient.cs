namespace Chapter7.Models
{
    public class MobilePlanClient
    {
        private IMobilePlanFactory _mobilePlanFactory;
        public MobilePlanClient(MobilePlan mobilePlan) { 
        
            if(mobilePlan == MobilePlan.Prepaid)
            {
                _mobilePlanFactory = new PrepaidFactory();
            }
            else
            {
                _mobilePlanFactory = new PostpaidFactory();
            }
        }

        public string Describe()
        {
            return @$"Mobile Plan: {_mobilePlanFactory.CreateConnectionSpeed().Name}.
                      Text Message: {_mobilePlanFactory.CreateTextMessage().Name}.
                      Internet Connection: {_mobilePlanFactory.CreateConnectionSpeed().Name}";
        }
    }
}
