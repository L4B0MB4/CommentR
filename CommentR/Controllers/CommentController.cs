using CommentR.Models;
using Microsoft.AspNetCore.Mvc;

namespace CommentR.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CommentController : ControllerBase
    {
        private readonly ILogger<CommentController> _logger;

        public CommentController(ILogger<CommentController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public IEnumerable<CommentVM> List()
        {
            Guid original = Guid.NewGuid();
            return Enumerable.Range(1, 5).Select(index => new CommentVM()
            {
                ID = Guid.NewGuid(),
                Content = "My " + index + ". content",
                CreatedDate = DateTime.Now,
                CreatorId = Guid.NewGuid(),
                OriginalID = original
            })
            .ToArray();
        }

        [HttpGet("{Id}")]
        public CommentVM Get(Guid Id)
        {
            Guid original = Guid.NewGuid();
            return new CommentVM()
            {
                ID = Id,
                Content = "My " + 0 + ". content",
                CreatedDate = DateTime.Now,
                CreatorId = Guid.NewGuid(),
                OriginalID = original
            };
        }
    }
}