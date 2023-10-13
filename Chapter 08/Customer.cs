using System.Runtime.Serialization.Formatters.Binary;

namespace Chapter8
{
    public class Customer: ICloneable
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Phone { get; set; }
        public Address Address { get; set; }

        public object Clone()
        {
            using(var memoryStream = new MemoryStream())
            {
                var binaryFormatter = new BinaryFormatter();
                binaryFormatter.Serialize(memoryStream, this);
                memoryStream.Position = 0;

                return (Customer)binaryFormatter.Deserialize(memoryStream);
            }
        }
    }

    public class Address
    {
        public string Street { get; set; }
    }
}






