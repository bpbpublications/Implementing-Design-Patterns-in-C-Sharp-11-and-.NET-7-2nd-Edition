namespace Chapter7.Models
{
    public class LowSpeed: IConnectionSpeedFactory
    {
        public string Name { get; set; } = "Low Speed";
        public string Velocity { get; set; } = "50 Mb/Sec";
    }
}



