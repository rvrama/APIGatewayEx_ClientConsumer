namespace Content.Api.Models
{
    public class ContentItem
    {
            public Guid Id { get; set; }
            public string Title { get; set; }
            public string Body { get; set; }
            public string Author { get; set; }
            public List<string> Categories { get; set; }
            public DateTime PublishedDate { get; set; }
    }
}
