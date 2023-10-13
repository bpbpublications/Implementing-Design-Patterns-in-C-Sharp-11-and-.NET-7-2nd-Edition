namespace Chapter7.Models
{
    public class UnlimitedMobileData: IMobileDataFactory
    {
        public string Name { get; set; } = "Unlimited";
        public string Limit { get; set; } = "Unlimited";
    }
}


