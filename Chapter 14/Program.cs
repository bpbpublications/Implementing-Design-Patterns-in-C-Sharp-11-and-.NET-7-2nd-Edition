namespace BPBBookChapter14
{
    internal class Program
    {
        static void Main(string[] args)
        {
            User user = new User();
            user.CityCode = "NYC";
            user.City = "New York";

            CityStrategyMethod cityStrategyMethod = new CityStrategyMethod();
            ICityStrategy cityStrategy = cityStrategyMethod.SetCityStrategy(user.CityCode);

            Delivery delivery = new Delivery(cityStrategy);
            delivery.Price = 10.00m;

            cityStrategy.ApplyEmploymentRules();
            Console.WriteLine($"Tax: {delivery.Tax}");
            Console.WriteLine($"Profit: {delivery.Profit}");


            Console.ReadLine();
        }
    }
}