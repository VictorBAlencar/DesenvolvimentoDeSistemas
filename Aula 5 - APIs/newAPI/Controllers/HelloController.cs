using  Microsoft.AspNetCore.Mvc;

namespace newAPI.Controllers{
    [ApiController]
    [Route("hello")] //Acessar rota
    public class HelloController : ControllerBase{ //ControllerBase -> herança básica
        [HttpGet]
        public IActionResult Get(){ //Interface
            return Ok(new {message = "Hello World."});
        }
    }
}