using Microsoft.AspNetCore.Mvc;

namespace GitOutApplication.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult Get()
        {
            return Ok(new { name = "Logan Kaas GitOut Application" });
        }
    }
}
