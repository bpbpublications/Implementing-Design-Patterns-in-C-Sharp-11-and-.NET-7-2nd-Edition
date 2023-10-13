namespace Chapter3.Models
{
    public struct Customer
    {
        public Customer(int id, string name, DateTime birthday)
        {
            Id = id;
            Name = name;
            BirthDay = birthday;
        }
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime BirthDay { get; set; }
    }
}




