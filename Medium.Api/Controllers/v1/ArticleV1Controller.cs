using Microsoft.AspNetCore.Mvc;

namespace Medium.Api.Controllers.v1 {
    
    [ApiController]
    [ApiVersion("1.0")]
    [Route("v{version:apiVersion}/article")]
    public class ArticleV1Controller : Controller {

        [HttpGet]
        public IActionResult Get () {
            return Ok (new { Message = "This message comes from version 1" });
        }
    }
}