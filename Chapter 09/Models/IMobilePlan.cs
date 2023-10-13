namespace Chapterr9.Models
{
    public interface IMobilePlan
    {
        IConnectionSpeed ConnectionSpeed { get; set; }
        ITextMessage TextMessage { get; set; }
    }
}


