namespace DesignPatternsBookChapter10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CustomerAdapter customerAdapter = new CustomerAdapter();
            var customers = customerAdapter.GetCustomers();

            Console.WriteLine(customers);

            Console.ReadLine();
        }
    }
}


