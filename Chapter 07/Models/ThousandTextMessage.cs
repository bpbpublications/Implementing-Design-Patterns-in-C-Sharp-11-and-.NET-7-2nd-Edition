namespace Chapter7.Models
{
    public class ThousandTextMessage: ITextMessageFactory
    {
        public string Name { get; set; } = "A thousand text messages";

        public string QuantityPerMonth { get; set; } = "1000";    }
}


