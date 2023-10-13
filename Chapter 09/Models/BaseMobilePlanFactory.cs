namespace Chapterr9.Models
{
    public abstract class BaseMobilePlanFactory
    {
        public IMobilePlan GetMobilePlan()
        {
            IMobilePlan mobilePlan = this.CreateMobilePlan();

            return mobilePlan;
        }

        public abstract IMobilePlan CreateMobilePlan();
    }
}


