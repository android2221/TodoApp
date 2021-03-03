using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ToDoApp.Entities;
using ToDoApp.Services;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ToDoApp.Controllers
{
    [Route("api/[controller]")]
    public class ToDosController : ControllerBase
    {
        private readonly IToDoService _toDoService;

        public ToDosController(IToDoService toDoService)
        {
            _toDoService = toDoService;
        }

        // GET: api/values
        [HttpGet]
        public async Task<List<ToDo>> Get()
        {
            return await _toDoService.GetAllToDos();
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
          return "true";
        }  

        // POST api/values
        [HttpPost]
        public async Task<int> Post([FromBody] ToDo value)
        {
          return await _toDoService.AddToDo(value);
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
