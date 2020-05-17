using Microsoft.AspNetCore.Mvc;

namespace Medium.Api.Controllers.v2
{
    [ApiController]
    [ApiVersion("2.0")]
    [Route("v{version:apiVersion}/article")]
    public class ArticleV2Controller : Controller
    {
        [HttpGet]
        public IActionResult Get () {
            return Ok (new { Message = "This message comes from version 2" });
        }
    }
}