using Chapterr9.Models;

namespace Chapterr9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            BaseMobilePlanFactory prePaidFactory = new PrePaidMobilePlanFactory();
            IMobilePlan prePaidMobilePlan = prePaidFactory.GetMobilePlan();

            BaseMobilePlanFactory postPaidFactory = new PostPaidMobilePlanFactory();
            IMobilePlan postPaidMobilePlan = prePaidFactory.GetMobilePlan();

            Console.WriteLine("*******POST-PAID MOBILE PLAN******");
            Console.WriteLine("Connection speed:" + postPaidMobilePlan.ConnectionSpeed.Velocity.ToString());
            Console.WriteLine("Text Message:" + postPaidMobilePlan.TextMessage);

            Console.WriteLine("*******POST-PAID MOBILE PLAN*****");
            Console.WriteLine("Connection speed:" + prePaidMobilePlan.ConnectionSpeed.Velocity.ToString());
            Console.WriteLine("Text Message:" + prePaidMobilePlan.TextMessage);

            Customer customer = new Customer("123456");

            var myString = "my string"u8;


            string dayOfWeekMessage = $"Todah is {
                DateTime.Now.DayOfWeek switch
                {
                    DayOfWeek.Monday => "Monday. Lets get back to work",
                    DayOfWeek.Friday => "Friday. Lets celebrate"
                }

            }";


            string[] arrayStrings = { "Jack", "Paul", "Mandy" };

            Console.WriteLine(arrayStrings is ["Jack", "Paul", "Mandy"]);  // True
            Console.WriteLine(arrayStrings is ["Jack", "Paul", "Silver"]);  // False
            Console.WriteLine(arrayStrings is ["Jack", "Paul", "Mandy", "Silver"]);  // False

            string rawString = """ This is a string with "quotes" in the content""";

            Console.Write(rawString);



        }
    }
}

