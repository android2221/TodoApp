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
        private readonly IBasicService<ToDo> _toDoService;

        public ToDosController(IBasicService<ToDo> toDoService)
        {
            _toDoService = toDoService;
        }

        // GET: api/values
        [HttpGet]
        public async Task<List<ToDo>> Get()
        {
            return await _toDoService.GetAllItems();
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public async Task<ToDo> Get(int id)
        {
          return await _toDoService.GetItem(id);
        }  

        // POST api/values
        [HttpPost]
        public async Task<int> Post([FromBody] ToDo value)
        {
          return await _toDoService.AddItem(value);
        }

        // PUT api/values/
        [HttpPut]
        public async Task<ToDo> Put([FromBody] ToDo value)
        {
          return await _toDoService.EditItem(value);
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public async Task Delete(int id)
        {
          await _toDoService.DeleteItem(id);
        }
    }
}
