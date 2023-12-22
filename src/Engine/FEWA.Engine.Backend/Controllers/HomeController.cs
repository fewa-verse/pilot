using System.Reflection;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace FEWA.Engine.Backend.Controllers
{
    [Route("")]
    [ApiController]
    public class HomeController : ControllerBase
    {
        [HttpGet]
        public IActionResult Get()
        {
            return Ok("FEWA Engine Backend");
        }
        
        [HttpGet("health")]
        public string Health()
        {
            return "Healthy";
        }
    }
}
