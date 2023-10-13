namespace Chapter7.Models
{
    public class UnlimitedTexxtMessage: ITextMessageFactory
    {
        public string Name { get; set; } = "Unlimited Text Messages";

        public string QuantityPerMonth { get; set; } = "Unlimited";
    }
}



