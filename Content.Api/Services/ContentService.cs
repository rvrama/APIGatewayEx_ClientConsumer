using Content.Api.Models;

namespace Content.Api.Services
{
    public class ContentService : IContentService
    {
        public IEnumerable<ContentItem> GetContentItems()
        {
            return new List<ContentItem>
        {
                new ContentItem
                {
                    Id =  new Guid("b198e834-b670-40c9-99bd-4a00c02df3b8"),
                    Title = "Understanding Microservices Architecture",
                    Body = "Microservices architecture allows building systems as a suite of independently deployable services. It helps in scaling and development efficiency...",
                    Author = "John Doe",
                    Categories = new List<string> { "Software Development", "Architecture", "Microservices" },
                    PublishedDate = new DateTime(2023, 5, 9)
                },
                new ContentItem
                {
                    Id = new Guid("59d01fb0-a679-40f3-adac-407af3cea5ad"),
                    Title = "The Rise of Artificial Intelligence in Healthcare",
                    Body = "AI is revolutionizing the healthcare industry by providing innovative solutions for diagnosis, patient care, and operational efficiency...",
                    Author = "Joe Smith",
                    Categories = new List<string> { "Healthcare", "AI", "Innovation" },
                    PublishedDate = new DateTime(2023, 6, 7)
                },
                new ContentItem
                {
                    Id = new Guid("80118e83-facf-49ee-b92e-67c1aafa33f6"),
                    Title = "Top 10 Investment Strategies for 2024",
                    Body = "With the global economy facing uncertainty, it's crucial to have a diversified investment portfolio. Here are the top 10 strategies to consider in 2024...",
                    Author = "Michael Cart",
                    Categories = new List<string> { "Finance", "Investment", "Economy" },
                    PublishedDate = new DateTime(2024, 1, 3)
                },
                new ContentItem
                {
                    Id = new Guid("3c4ae9f5-b3ec-47d7-ad93-aff609ac920e"),
                    Title = "How to Cook the Perfect Steak: A Guide for Beginners",
                    Body = "Cooking a perfect steak requires the right balance of heat, timing, and technique. Follow these steps to impress at your next dinner party...",
                    Author = "Sarah Lever",
                    Categories = new List<string> { "Cooking", "Lifestyle", "Food" },
                    PublishedDate = new DateTime(2023, 8, 9)
                }
            };
        }
    }
}
