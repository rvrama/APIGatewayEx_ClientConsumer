using Content.Api.Services;
using Microsoft.AspNetCore.Mvc;

namespace APIGatewayEx_ClientConsumer.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ContentController : ControllerBase
    {
        private readonly IContentService _contentService;

        public ContentController(IContentService contentService)
        {
            _contentService = contentService;
        }
        [HttpGet]
        public IActionResult GetAll() => Ok(_contentService.GetContentItems());
    }
}
