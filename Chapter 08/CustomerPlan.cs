using System.Runtime.Serialization.Formatters.Binary;

namespace Chapter8
{
    [Serializable]
    public class CustomerPlan
    {
        public PlanVersion PlanVersion { get; set; }
        public decimal Price { get; set; }
        public string Name { get; set; }
        public List<string> CompanyPolicies { get; set; }
        public List<string> Regulations { get; set; }
        public List<string> Languages { get; set; }

        public object DeepCopy()
        {
            using(var memoryStream = new MemoryStream())
            {
                var binaryFormatter = new BinaryFormatter();
                binaryFormatter.Serialize(memoryStream, this);
                memoryStream.Position = 0;

                return (CustomerPlan) binaryFormatter.Deserialize(memoryStream);
            }
        }
    }

    [Serializable]
    public class PlanVersion
    {
        public int VersionNumber { get; set; }
        public DateTime Creation { get; set; }
        public DateTime Expiration { get; set; }
    }
}

