namespace Chapter7.Models
{
    public class HighSpeed: IConnectionSpeedFactory
    {
        public string Name { get; set; } = "High Speed";
        public string Velocity { get; set; } = "500 Mb/Sec";
    }
}


