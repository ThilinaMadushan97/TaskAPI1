using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TaskAPI1.Models;
using TaskAPI1.Service;

namespace TaskAPI1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TodosController : ControllerBase
    {
        private TodoService _todoService;

        public TodosController()
        {
            _todoService = new TodoService();
        }

        [HttpGet ("{id?}")] //Optional parameter

        public IActionResult GetTodos(int? id) //Optional parameter
        {
            var MyTodos = _todoService.GetAllTodos();

            if(id == null) return Ok(MyTodos);

            MyTodos = MyTodos.Where(t => t.Id == id).ToList();

            return Ok(MyTodos);
        }

        
    }
}
