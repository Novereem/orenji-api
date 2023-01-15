using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;

namespace orenji_backend.Controllers
{
    [EnableCors("AllowCors")]
    [ApiController]
    [Route("[controller]")]
    public class TestController : Controller
    {
        [AllowAnonymous]
        [HttpGet]
        public string PerformanceTest()
        {
            return "TEST";
        }
    }
}