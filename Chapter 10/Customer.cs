using System.Xml.Serialization;

namespace DesignPatternsBookChapter10
{
    [Serializable]
    public class Customer
    {
        [XmlAttribute]
        public int Id { get; set; }
        [XmlAttribute]
        public string Name { get; set; }
        [XmlAttribute]
        public string Address { get; set; }
        [XmlAttribute]
        public string City { get; set; }
        [XmlAttribute]
        public string Country { get; set; }
        [XmlAttribute]
        public string DocumentNumber { get; set; }
        [XmlAttribute]
        public DateTime BirthDay { get; set; }
    }
}


