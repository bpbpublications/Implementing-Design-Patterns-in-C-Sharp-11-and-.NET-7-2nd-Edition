class Book
{
    public int Id { get; set; }
    public string Title { get; set; }
    public DateTime Creation { get; set; }
    public Author Author { get; set; }
    public string Summary { get; set; }
    public int IsNumber { get; set; }
}

class Author
{
    public int Id { get; set; }
    public string Name { get; set; }
}