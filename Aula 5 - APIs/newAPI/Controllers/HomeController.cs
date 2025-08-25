using  Microsoft.AspNetCore.Mvc;

namespace newAPI.Controllers{
    [ApiController]
    [Route("")]
    public class HomeController : ControllerBase{
        [HttpGet]
        public IActionResult Index(){
            return Ok(new {message = "Welcome."});
        }
    }
}