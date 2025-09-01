using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;

namespace newAPI.Controllers{
    [ApiController]
    [Route("todos")]
    public class ToDosController : ControllerBase{
        private static readonly List<ToDo> ToDos = new();

        private static int _nextId = 1;

        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public ActionResult<IEnumerable<ToDo>> GetAll() => Ok(ToDos);


        [HttpPost]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public IActionResult Create([FromBody] CreateToDoDto dto){
            var ToDo = new ToDo(_nextId++, dto.Title.Trim(), dto.Priority, false);
        return Created($"/ToDos/{ToDo.Id}", ToDo);
        } 
    }
    public record class CreateToDoDto{
        [Required, MinLength(3)]

        public string Title{get; init;} = string.Empty;
        [Range(0,5)]
        public int Priority{get;init;}
    }
    public record ToDo(int Id, string Title, int Priority, bool Done);
}