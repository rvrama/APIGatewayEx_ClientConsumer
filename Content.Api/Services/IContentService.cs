using Content.Api.Models;

namespace Content.Api.Services
{
    public interface IContentService
    {
        IEnumerable<ContentItem> GetContentItems();
    }
}
