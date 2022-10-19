using Microsoft.AspNetCore.Mvc;

namespace Charlee.Controllers
{
    [ApiController]
    [Route("[controller]/[action]")]
    public class TestApiController : Controller
    {
        [HttpGet]
        [Route("/[controller]")]
        public IActionResult Index()
        {
            return Ok("TestApi");
        }

        /// <summary>
        /// Returns 200 OK and a greeting including the name provided
        /// </summary>
        /// <param name="name">Name which to greet</param>
        /// <returns>OkObjectResult</returns>
        [HttpGet]
        public IActionResult Greet([FromQuery] string name)
        {
            return Ok("Hello " + name);
        }
    }
}
