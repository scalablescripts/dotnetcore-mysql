using dotnet.Data;
using Microsoft.AspNetCore.Mvc;

namespace dotnet.Controllers
{
    [Route("api")]
    [ApiController]
    public class ProductController : Controller
    {
        private readonly ProductRepository _repository;

        public ProductController(ProductRepository repository)
        {
            _repository = repository;
        }

        [HttpGet("products/frontend")]
        public IActionResult Frontend()
        {
            return Ok(_repository.All());
        }

        [HttpGet("products/backend")]
        public IActionResult Backend(
            [FromQuery(Name = "s")] string s,
            [FromQuery(Name = "sort")] string sort,
            [FromQuery(Name = "page")] int page
        )
        {
            return Ok(_repository.Query(s, sort, page));
        }
    }
}