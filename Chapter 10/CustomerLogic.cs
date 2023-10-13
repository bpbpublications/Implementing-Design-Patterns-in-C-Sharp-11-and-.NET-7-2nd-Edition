using System.Xml;
using System.Xml.Serialization;

namespace DesignPatternsBookChapter10
{
    public class CustomerLogic
    {
        private List<Customer> customers;
        public CustomerLogic()
        {
            customers = new List<Customer>();
            customers.Add(new Customer() { Id = 1, Name = "Customer 1", City = "New York" });
            customers.Add(new Customer() { Id = 2, Name = "Customer 2", City = "Los Angeles" });
            customers.Add(new Customer() { Id = 3, Name = "Customer 3", City = "Las Vegas" });
            customers.Add(new Customer() { Id = 4, Name = "Customer 4", City = "Sao Paulo" });
            customers.Add(new Customer() { Id = 5, Name = "Customer 5", City = "Dublin" });
        }

        public virtual string GetCustomers()
        {
            var xmlSerializer = new XmlSerializer(customers.GetType());
            using (var stream = new StringWriter())
            {
                using (var xmlWriter = XmlWriter.Create(stream))
                {
                    xmlSerializer.Serialize(xmlWriter, customers);
                    return stream.ToString();
                }
            }
        }
    }
}


