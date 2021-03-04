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
        private readonly IBasicService _toDoService;

        public ToDosController(IBasicService toDoService)
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
        public async Task<ToDo> Get(int id)
        {
          return await _toDoService.GetToDo(id);
        }  

        // POST api/values
        [HttpPost]
        public async Task<int> Post([FromBody] ToDo value)
        {
          return await _toDoService.AddToDo(value);
        }

        // PUT api/values/
        [HttpPut]
        public async Task<ToDo> Put([FromBody] ToDo value)
        {
          return await _toDoService.EditToDo(value);
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public async void Delete(int id)
        {
          await _toDoService.DeleteToDo(id);
        }
    }
}
