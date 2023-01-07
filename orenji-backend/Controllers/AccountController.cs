using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;

namespace orenji_backend.Controllers
{
    [EnableCors("AllowCors")]
    [ApiController]
    [Route("[controller]")]
    public class AccountController : Controller
    {
        
    }
}